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
            lbl_filename = new Label();
            txtFilename = new TextBox();
            btnClear = new Button();
            btnSubmit = new Button();
            lbl_Title = new Label();
            picbox_swModes = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picbox_swModes).BeginInit();
            SuspendLayout();
            // 
            // btn_newNote
            // 
            btn_newNote.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btn_newNote.BackColor = Color.Transparent;
            btn_newNote.BackgroundImage = Properties.Resources.btn_delete;
            btn_newNote.BackgroundImageLayout = ImageLayout.Stretch;
            btn_newNote.FlatAppearance.BorderSize = 0;
            btn_newNote.FlatStyle = FlatStyle.Flat;
            btn_newNote.Location = new Point(12, 417);
            btn_newNote.Name = "btn_newNote";
            btn_newNote.Size = new Size(24, 24);
            btn_newNote.TabIndex = 0;
            btn_newNote.UseVisualStyleBackColor = false;
            btn_newNote.Click += Btn_Delete_Click;
            // 
            // lst_ListNotes
            // 
            lst_ListNotes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            lst_ListNotes.BackColor = SystemColors.InactiveCaption;
            lst_ListNotes.BorderStyle = BorderStyle.FixedSingle;
            lst_ListNotes.FullRowSelect = true;
            lst_ListNotes.GridLines = true;
            lst_ListNotes.Location = new Point(12, 103);
            lst_ListNotes.MultiSelect = false;
            lst_ListNotes.Name = "lst_ListNotes";
            lst_ListNotes.Size = new Size(264, 308);
            lst_ListNotes.Sorting = SortOrder.Descending;
            lst_ListNotes.TabIndex = 1;
            lst_ListNotes.UseCompatibleStateImageBehavior = false;
            lst_ListNotes.View = View.List;
            lst_ListNotes.SelectedIndexChanged += Lst_ListNotes_SelectedIndexChanged;
            // 
            // txtNote
            // 
            txtNote.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtNote.BackColor = Color.LemonChiffon;
            txtNote.BorderStyle = BorderStyle.None;
            txtNote.Location = new Point(282, 103);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(290, 234);
            txtNote.TabIndex = 2;
            // 
            // lbl_filename
            // 
            lbl_filename.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            lbl_filename.AutoSize = true;
            lbl_filename.BackColor = Color.Transparent;
            lbl_filename.Font = new Font("Yu Gothic UI", 9F);
            lbl_filename.Location = new Point(322, 337);
            lbl_filename.Name = "lbl_filename";
            lbl_filename.Size = new Size(54, 15);
            lbl_filename.TabIndex = 8;
            lbl_filename.Text = "Filename";
            // 
            // txtFilename
            // 
            txtFilename.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            txtFilename.BackColor = Color.WhiteSmoke;
            txtFilename.BorderStyle = BorderStyle.None;
            txtFilename.Font = new Font("Segoe UI", 12F);
            txtFilename.Location = new Point(322, 355);
            txtFilename.Name = "txtFilename";
            txtFilename.Size = new Size(166, 22);
            txtFilename.TabIndex = 7;
            // 
            // btnClear
            // 
            btnClear.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnClear.BackColor = Color.Transparent;
            btnClear.BackgroundImage = Properties.Resources.btn_remove;
            btnClear.BackgroundImageLayout = ImageLayout.Stretch;
            btnClear.FlatAppearance.BorderSize = 0;
            btnClear.FlatStyle = FlatStyle.Flat;
            btnClear.Location = new Point(556, 343);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(16, 16);
            btnClear.TabIndex = 6;
            btnClear.UseVisualStyleBackColor = false;
            btnClear.Click += BtnClear_Click;
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnSubmit.BackColor = Color.Transparent;
            btnSubmit.BackgroundImage = Properties.Resources.save_btn;
            btnSubmit.BackgroundImageLayout = ImageLayout.Stretch;
            btnSubmit.FlatAppearance.BorderSize = 0;
            btnSubmit.FlatStyle = FlatStyle.Flat;
            btnSubmit.Location = new Point(497, 343);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(35, 35);
            btnSubmit.TabIndex = 5;
            btnSubmit.UseVisualStyleBackColor = false;
            btnSubmit.Click += BtnSubmit_Click;
            // 
            // lbl_Title
            // 
            lbl_Title.AutoSize = true;
            lbl_Title.BackColor = Color.Transparent;
            lbl_Title.Font = new Font("Yu Gothic UI", 48F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0, true);
            lbl_Title.ForeColor = Color.DimGray;
            lbl_Title.Location = new Point(183, 9);
            lbl_Title.Name = "lbl_Title";
            lbl_Title.Size = new Size(209, 86);
            lbl_Title.TabIndex = 9;
            lbl_Title.Text = "Notes";
            // 
            // picbox_swModes
            // 
            picbox_swModes.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            picbox_swModes.BackColor = Color.Transparent;
            picbox_swModes.BackgroundImage = Properties.Resources.swmode_light;
            picbox_swModes.BackgroundImageLayout = ImageLayout.Stretch;
            picbox_swModes.InitialImage = Properties.Resources.swmode_light;
            picbox_swModes.Location = new Point(497, 12);
            picbox_swModes.Name = "picbox_swModes";
            picbox_swModes.Size = new Size(64, 64);
            picbox_swModes.TabIndex = 11;
            picbox_swModes.TabStop = false;
            picbox_swModes.Click += Picbox_swModes_Click;
            // 
            // NotesAppForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            BackColor = SystemColors.Info;
            BackgroundImage = Properties.Resources.background_light;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(584, 461);
            Controls.Add(picbox_swModes);
            Controls.Add(lbl_Title);
            Controls.Add(lbl_filename);
            Controls.Add(txtFilename);
            Controls.Add(btnClear);
            Controls.Add(btnSubmit);
            Controls.Add(txtNote);
            Controls.Add(lst_ListNotes);
            Controls.Add(btn_newNote);
            DoubleBuffered = true;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimumSize = new Size(600, 500);
            Name = "NotesAppForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Notes App";
            ((System.ComponentModel.ISupportInitialize)picbox_swModes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_newNote;
        private ListView lst_ListNotes;
        private TextBox txtNote;
        private Label lbl_filename;
        private TextBox txtFilename;
        private Button btnClear;
        private Button btnSubmit;
        private Label lbl_Title;
        private PictureBox picbox_swModes;
    }
}
