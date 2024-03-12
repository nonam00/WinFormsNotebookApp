namespace WinFormsNotebookApp
{
    public partial class NotebookForm : Form
    {
        static int countDocs = 0;
        List<TabDocument> tabDocs = new();

        public NotebookForm()
        {
            InitializeComponent();

            var filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";

            openFileDialog.Filter = filter;
            saveFileDialog.Filter = filter;

            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.AddExtension = true;
            saveFileDialog.InitialDirectory = @"D:/RPO";

            saveFileDialog.CreatePrompt = false;
            saveFileDialog.OverwritePrompt = false;

            fontDialog.ShowColor = true;

            colorDialog.FullOpen = true;
            colorDialog.SolidColorOnly = true;

			CreateTabDocumnet();
        }

        private void fileCreateMenuItem_Click(object sender, EventArgs e)
        {
            CreateTabDocumnet();
        }

        private void fileOpenMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            var fileName = openFileDialog.FileName;

            TabDocument tabDoc = CreateTabDocumnet(fileName.Remove(0, fileName.LastIndexOf("\\") + 1));
            tabDoc.FileName = fileName;
            tabDoc.IsNew = false;

            var text = File.ReadAllText(fileName);
            tabDoc.EditBox.Text = text;
            tabDoc.Page.Text = fileName.Remove(0, fileName.LastIndexOf("\\") + 1);
            tabDoc.IsSave = true;
        }

        private void fileSaveMenuItem_Click(object sender, EventArgs e)
        {
            TabDocument docCurrent = CurrentDocument();
            if (docCurrent.IsSave) return;

            string fileName;

            if (docCurrent.IsNew)
            {
                if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                    return;
                fileName = saveFileDialog.FileName;
            }
            else
                fileName = docCurrent.FileName;

            File.WriteAllText(fileName, docCurrent.EditBox.Text);

            if (docCurrent.IsNew)
            {
                docCurrent.FileName = fileName;
                docCurrent.Page.Text = fileName.Remove(0, fileName.LastIndexOf("\\") + 1);
                docCurrent.IsNew = false;
            }
            else
            {
                docCurrent.Page.Text = docCurrent.Page.Text.Remove(docCurrent.Page.Text.Length - 2);
            }
            docCurrent.IsSave = true;
        }

        private void formatFontMenuItem_Click(object sender, EventArgs e)
        {
            if (fontDialog.ShowDialog() == DialogResult.Cancel)
                return;

            TabDocument? docCurrent = CurrentDocument();

            docCurrent.EditBox.Font = fontDialog.Font;
            docCurrent.EditBox.ForeColor = fontDialog.Color;
        }

        private void formatColorMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.Cancel)
                return;

            TabDocument? docCurrent = CurrentDocument();

            docCurrent.EditBox.BackColor = colorDialog.Color;
        }

        TabDocument CreateTabDocumnet(string title = "")
        {
            title = (title == "") ? $"Новый документ {++countDocs}" : title;

            TabPage tabPage = new TabPage(title);
            editTabControl.Controls.Add(tabPage);
            editTabControl.SelectedTab = tabPage;

            TextBox editBox = new();
            editBox.Multiline = true;
            editBox.Dock = DockStyle.Fill;
            editBox.TextChanged += editBox_TextChanged;
            editBox.Click += editBox_Click;

            tabPage.Controls.Add(editBox);

            TabDocument tabDoc = new(
                tabPage,
                editBox
                );

            tabDocs.Add(tabDoc);

            return tabDoc;
        }

        private void editBox_Click(object? sender, EventArgs e)
        {
            UpdateCharPos();
		}

		private void editBox_TextChanged(object? sender, EventArgs e)
        {
            TabDocument docCurrent = CurrentDocument();

            UpdateCharPos();

			if (docCurrent.IsSave)
                docCurrent.Page.Text += " *";
            docCurrent.IsSave = false;
        }

        private void fileCloseMenuItem_Click(object sender, EventArgs e)
        {
            TabDocument? docCurrent = CurrentDocument();

            if (!docCurrent.IsSave)
            {
                var result = MessageBox.Show
                    ("Файл не сохранен. Сохранить?",
                    "Файл не сохранен.",
                    MessageBoxButtons.YesNoCancel,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Cancel)
                    return;
                else if (result == DialogResult.Yes)
                {
                    string fileName;
                    if (docCurrent.IsNew)
                    {
                        if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                            return;
                        fileName = saveFileDialog.FileName;
                    }
                    else
                        fileName = docCurrent.FileName;
                    File.WriteAllText(fileName, docCurrent.EditBox.Text);
                }
            }

            tabDocs.Remove(docCurrent);
            editTabControl.Controls.Remove(docCurrent.Page);
        }

        TabDocument CurrentDocument()
        {
            TabPage? pageCurrent = editTabControl.SelectedTab;
            TabDocument? docCurrent = tabDocs.FirstOrDefault(d => d.Page == pageCurrent);
            return docCurrent;
        }

        private void NotebookForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(var d in tabDocs)
            {
                if (!d.IsSave)
                    fileSaveMenuItem_Click(null, null);
            }
        }

        // функция обновляющая отображаемую позицию в тексте 
        private void UpdateCharPos()
        {
			TabDocument docCurrent = CurrentDocument(); //получение объекта текущего документа
            
            // получение номера строки
			int lineNumber = docCurrent.EditBox.GetLineFromCharIndex(docCurrent.EditBox.SelectionStart);
			//получение индекса первого символа полученной строки относительно всего текста
			int lineFirstCharPosition = docCurrent.EditBox.GetFirstCharIndexFromLine(lineNumber);
			// получение текущего индекса относительно строки
			int lineCharPosition = docCurrent.EditBox.SelectionStart - lineFirstCharPosition; 

			rowStatusItem.Text = $"Строка: {lineNumber + 1}, Символ: {lineCharPosition + 1}";
		}
    }
}
