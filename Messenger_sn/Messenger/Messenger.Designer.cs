namespace Messenger
{
    partial class Messenger
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button_Maria = new System.Windows.Forms.Button();
            this.button_Ionel = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.button_upload = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(12, 12);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(849, 315);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.TabStop = false;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.Location = new System.Drawing.Point(168, 333);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(542, 47);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // button_Maria
            // 
            this.button_Maria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Maria.Location = new System.Drawing.Point(12, 333);
            this.button_Maria.Name = "button_Maria";
            this.button_Maria.Size = new System.Drawing.Size(123, 47);
            this.button_Maria.TabIndex = 2;
            this.button_Maria.Text = "Maria";
            this.button_Maria.UseVisualStyleBackColor = true;
            this.button_Maria.Click += new System.EventHandler(this.button_Maria_Click);
            // 
            // button_Ionel
            // 
            this.button_Ionel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Ionel.Location = new System.Drawing.Point(738, 333);
            this.button_Ionel.Name = "button_Ionel";
            this.button_Ionel.Size = new System.Drawing.Size(123, 47);
            this.button_Ionel.TabIndex = 3;
            this.button_Ionel.Text = "Ionel";
            this.button_Ionel.UseVisualStyleBackColor = true;
            this.button_Ionel.Click += new System.EventHandler(this.button_Ionel_Click);
            // 
            // button_Save
            // 
            this.button_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Save.Location = new System.Drawing.Point(12, 391);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(226, 47);
            this.button_Save.TabIndex = 4;
            this.button_Save.Text = "Salvare mesaje";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // button_upload
            // 
            this.button_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_upload.Location = new System.Drawing.Point(639, 391);
            this.button_upload.Name = "button_upload";
            this.button_upload.Size = new System.Drawing.Size(222, 47);
            this.button_upload.TabIndex = 5;
            this.button_upload.Text = "Incarcare mesaje";
            this.button_upload.UseVisualStyleBackColor = true;
            this.button_upload.Click += new System.EventHandler(this.button_upload_Click);
            // 
            // button_delete
            // 
            this.button_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_delete.Location = new System.Drawing.Point(253, 391);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(362, 47);
            this.button_delete.TabIndex = 6;
            this.button_delete.Text = "Stergere mesaje";
            this.button_delete.UseVisualStyleBackColor = true;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // Messenger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 450);
            this.Controls.Add(this.button_delete);
            this.Controls.Add(this.button_upload);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Ionel);
            this.Controls.Add(this.button_Maria);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Messenger";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Messenger";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button_Maria;
        private System.Windows.Forms.Button button_Ionel;
        private System.Windows.Forms.Button button_Save;
        private System.Windows.Forms.Button button_upload;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}