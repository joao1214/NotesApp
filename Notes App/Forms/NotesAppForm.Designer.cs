namespace Notes_App
{
    partial class NotesAppForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NotesAppForm));
            btn_newNote = new Button();
            lst_ListNotes = new ListView();
            txtNote = new TextBox();
            label1 = new Label();
            txtFilename = new TextBox();
            btnClear = new Button();
            btnSubmit = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // btn_newNote
            // 
            btn_newNote.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_newNote.Location = new Point(12, 549);
            btn_newNote.Name = "btn_newNote";
            btn_newNote.Size = new Size(75, 23);
            btn_newNote.TabIndex = 0;
            btn_newNote.Text = "Delete";
            btn_newNote.UseVisualStyleBackColor = true;
            btn_newNote.Click += Btn_Delete_Click;
            // 
            // lst_ListNotes
            // 
            lst_ListNotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lst_ListNotes.BackColor = SystemColors.InactiveCaption;
            lst_ListNotes.FullRowSelect = true;
            lst_ListNotes.GridLines = true;
            lst_ListNotes.Location = new Point(12, 134);
            lst_ListNotes.MultiSelect = false;
            lst_ListNotes.Name = "lst_ListNotes";
            lst_ListNotes.Size = new Size(227, 409);
            lst_ListNotes.Sorting = SortOrder.Descending;
            lst_ListNotes.TabIndex = 1;
            lst_ListNotes.UseCompatibleStateImageBehavior = false;
            lst_ListNotes.View = View.List;
            lst_ListNotes.SelectedIndexChanged += Lst_ListNotes_SelectedIndexChanged;
            // 
            // txtNote
            // 
            txtNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNote.BackColor = SystemColors.ScrollBar;
            txtNote.Location = new Point(256, 134);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(612, 409);
            txtNote.TabIndex = 2;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Location = new Point(419, 553);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 8;
            label1.Text = "Filename: ";
            // 
            // txtFilename
            // 
            txtFilename.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtFilename.Location = new Point(486, 550);
            txtFilename.Name = "txtFilename";
            txtFilename.Size = new Size(261, 23);
            txtFilename.TabIndex = 7;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.Location = new Point(776, 575);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 6;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += BtnClear_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmit.Location = new Point(753, 550);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(115, 23);
            btnSubmit.TabIndex = 5;
            btnSubmit.Text = "Save";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += BtnSubmit_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Historic", 36F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.Location = new Point(138, 9);
            label2.Name = "label2";
            label2.Size = new Size(262, 65);
            label2.TabIndex = 9;
            label2.Text = "Notes App";
            // 
            // NotesAppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Info;
            ClientSize = new Size(884, 611);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtFilename);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(txtNote);
            Controls.Add(lst_ListNotes);
            Controls.Add(btn_newNote);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(900, 650);
            Name = "NotesAppForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notes App";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_newNote;
        private ListView lst_ListNotes;
        private TextBox txtNote;
        private Label label1;
        private TextBox txtFilename;
        private Button btnClear;
        private Button btnSubmit;
        private Label label2;
    }
}
