namespace WinFormsTest
{
    partial class WinFormsTest
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
            datesList = new ListView();
            btnAdd = new Button();
            datePickerDate = new DateTimePicker();
            SuspendLayout();
            // 
            // datesList
            // 
            datesList.Location = new Point(342, 22);
            datesList.Name = "datesList";
            datesList.Size = new Size(139, 354);
            datesList.TabIndex = 0;
            datesList.UseCompatibleStateImageBehavior = false;
            datesList.SelectedIndexChanged += datesList_SelectedIndexChanged;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(355, 398);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(107, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Hinzufügen";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // datePickerDate
            // 
            datePickerDate.Location = new Point(12, 197);
            datePickerDate.Name = "datePickerDate";
            datePickerDate.Size = new Size(290, 27);
            datePickerDate.TabIndex = 2;
            // 
            // WinFormsTest
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 450);
            Controls.Add(datePickerDate);
            Controls.Add(btnAdd);
            Controls.Add(datesList);
            Name = "WinFormsTest";
            Text = "WinFormsTest";
            ResumeLayout(false);
        }

        #endregion

        private ListView datesList;
        private Button btnAdd;
        private DateTimePicker datePickerDate;
    }
}
