namespace WinFormsNotebookApp
{
    partial class NotebookForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotebookForm));
            openFileDialog = new OpenFileDialog();
            saveFileDialog = new SaveFileDialog();
            fontDialog = new FontDialog();
            colorDialog = new ColorDialog();
            mainMenuStrip = new MenuStrip();
            fileMenuItem = new ToolStripMenuItem();
            fileCreateMenuItem = new ToolStripMenuItem();
            fileOpenMenuItem = new ToolStripMenuItem();
            fileCloseMenuItem = new ToolStripMenuItem();
            fileSaveMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            quitMenuItem = new ToolStripMenuItem();
            formatMenuItem = new ToolStripMenuItem();
            formatFontMenuItem = new ToolStripMenuItem();
            formatColorMenuItem = new ToolStripMenuItem();
            mainToolsStrip = new ToolStrip();
            fileCreateToolItem = new ToolStripButton();
            mainStatusStrip = new StatusStrip();
            rowStatusItem = new ToolStripStatusLabel();
            tabPage1 = new TabPage();
            txtEdit = new TextBox();
            editTabControl = new TabControl();
            mainMenuStrip.SuspendLayout();
            mainToolsStrip.SuspendLayout();
            mainStatusStrip.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // mainMenuStrip
            // 
            mainMenuStrip.Items.AddRange(new ToolStripItem[] { fileMenuItem, formatMenuItem });
            mainMenuStrip.Location = new Point(0, 0);
            mainMenuStrip.Name = "mainMenuStrip";
            mainMenuStrip.Size = new Size(803, 24);
            mainMenuStrip.TabIndex = 3;
            // 
            // fileMenuItem
            // 
            fileMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fileCreateMenuItem, fileOpenMenuItem, fileCloseMenuItem, fileSaveMenuItem, toolStripMenuItem1, quitMenuItem });
            fileMenuItem.Name = "fileMenuItem";
            fileMenuItem.Size = new Size(48, 20);
            fileMenuItem.Text = "Файл";
            // 
            // fileCreateMenuItem
            // 
            fileCreateMenuItem.Name = "fileCreateMenuItem";
            fileCreateMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            fileCreateMenuItem.Size = new Size(173, 22);
            fileCreateMenuItem.Text = "Создать";
            fileCreateMenuItem.Click += fileCreateMenuItem_Click;
            // 
            // fileOpenMenuItem
            // 
            fileOpenMenuItem.Name = "fileOpenMenuItem";
            fileOpenMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            fileOpenMenuItem.Size = new Size(173, 22);
            fileOpenMenuItem.Text = "Открыть";
            fileOpenMenuItem.Click += fileOpenMenuItem_Click;
            // 
            // fileCloseMenuItem
            // 
            fileCloseMenuItem.Image = (Image)resources.GetObject("fileCloseMenuItem.Image");
            fileCloseMenuItem.Name = "fileCloseMenuItem";
            fileCloseMenuItem.Size = new Size(173, 22);
            fileCloseMenuItem.Text = "Закрыть";
            fileCloseMenuItem.Click += fileCloseMenuItem_Click;
            // 
            // fileSaveMenuItem
            // 
            fileSaveMenuItem.Name = "fileSaveMenuItem";
            fileSaveMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            fileSaveMenuItem.Size = new Size(173, 22);
            fileSaveMenuItem.Text = "Сохранить";
            fileSaveMenuItem.Click += fileSaveMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(170, 6);
            // 
            // quitMenuItem
            // 
            quitMenuItem.Name = "quitMenuItem";
            quitMenuItem.Size = new Size(173, 22);
            quitMenuItem.Text = "Выход";
            // 
            // formatMenuItem
            // 
            formatMenuItem.DropDownItems.AddRange(new ToolStripItem[] { formatFontMenuItem, formatColorMenuItem });
            formatMenuItem.Name = "formatMenuItem";
            formatMenuItem.Size = new Size(62, 20);
            formatMenuItem.Text = "Формат";
            // 
            // formatFontMenuItem
            // 
            formatFontMenuItem.Name = "formatFontMenuItem";
            formatFontMenuItem.Size = new Size(113, 22);
            formatFontMenuItem.Text = "Шрифт";
            formatFontMenuItem.Click += formatFontMenuItem_Click;
            // 
            // formatColorMenuItem
            // 
            formatColorMenuItem.Name = "formatColorMenuItem";
            formatColorMenuItem.Size = new Size(113, 22);
            formatColorMenuItem.Text = "Цвет";
            formatColorMenuItem.Click += formatColorMenuItem_Click;
            // 
            // mainToolsStrip
            // 
            mainToolsStrip.Items.AddRange(new ToolStripItem[] { fileCreateToolItem });
            mainToolsStrip.Location = new Point(0, 24);
            mainToolsStrip.Name = "mainToolsStrip";
            mainToolsStrip.Size = new Size(803, 25);
            mainToolsStrip.TabIndex = 4;
            // 
            // fileCreateToolItem
            // 
            fileCreateToolItem.Image = (Image)resources.GetObject("fileCreateToolItem.Image");
            fileCreateToolItem.ImageTransparentColor = Color.Magenta;
            fileCreateToolItem.Name = "fileCreateToolItem";
            fileCreateToolItem.Size = new Size(70, 22);
            fileCreateToolItem.Text = "Создать";
            fileCreateToolItem.Click += fileCreateMenuItem_Click;
            // 
            // mainStatusStrip
            // 
            mainStatusStrip.Items.AddRange(new ToolStripItem[] { rowStatusItem });
            mainStatusStrip.Location = new Point(0, 518);
            mainStatusStrip.Name = "mainStatusStrip";
            mainStatusStrip.Size = new Size(803, 22);
            mainStatusStrip.TabIndex = 5;
            // 
            // rowStatusItem
            // 
            rowStatusItem.Name = "rowStatusItem";
            rowStatusItem.Size = new Size(0, 17);
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(txtEdit);
            tabPage1.Location = new Point(0, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(795, 441);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtEdit
            // 
            txtEdit.Dock = DockStyle.Fill;
            txtEdit.Location = new Point(3, 3);
            txtEdit.Multiline = true;
            txtEdit.Name = "txtEdit";
            txtEdit.Size = new Size(789, 435);
            txtEdit.TabIndex = 1;
            // 
            // editTabControl
            // 
            editTabControl.Dock = DockStyle.Fill;
            editTabControl.Location = new Point(0, 49);
            editTabControl.Name = "editTabControl";
            editTabControl.SelectedIndex = 0;
            editTabControl.Size = new Size(803, 469);
            editTabControl.TabIndex = 6;
            // 
            // NotebookForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(803, 540);
            Controls.Add(editTabControl);
            Controls.Add(mainStatusStrip);
            Controls.Add(mainToolsStrip);
            Controls.Add(mainMenuStrip);
            MainMenuStrip = mainMenuStrip;
            Name = "NotebookForm";
            Text = "Блокнот";
            FormClosing += NotebookForm_FormClosing;
            mainMenuStrip.ResumeLayout(false);
            mainMenuStrip.PerformLayout();
            mainToolsStrip.ResumeLayout(false);
            mainToolsStrip.PerformLayout();
            mainStatusStrip.ResumeLayout(false);
            mainStatusStrip.PerformLayout();
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog;
        private SaveFileDialog saveFileDialog;
        private FontDialog fontDialog;
        private ColorDialog colorDialog;
        private MenuStrip mainMenuStrip;
        private ToolStripMenuItem fileMenuItem;
        private ToolStripMenuItem fileCreateMenuItem;
        private ToolStripMenuItem fileOpenMenuItem;
        private ToolStripMenuItem fileSaveMenuItem;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem quitMenuItem;
        private ToolStripMenuItem formatMenuItem;
        private ToolStripMenuItem formatFontMenuItem;
        private ToolStripMenuItem formatColorMenuItem;
        private ToolStrip mainToolsStrip;
        private StatusStrip mainStatusStrip;
        private TabPage tabPage1;
        private TextBox txtEdit;
        private TabControl editTabControl;
        private ToolStripMenuItem fileCloseMenuItem;
        private ToolStripButton fileCreateToolItem;
        private ToolStripStatusLabel rowStatusItem;
    }
}
