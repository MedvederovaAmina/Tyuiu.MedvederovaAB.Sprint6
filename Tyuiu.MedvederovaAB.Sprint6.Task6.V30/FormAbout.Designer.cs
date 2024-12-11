namespace Tyuiu.MedvederovaAB.Sprint6.Task6.V30
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonYes_MAB = new Button();
            labelInfo_MAB = new Label();
            pictureBoxAvatar_MAB = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_MAB).BeginInit();
            SuspendLayout();
            // 
            // buttonYes_MAB
            // 
            buttonYes_MAB.Location = new Point(476, 238);
            buttonYes_MAB.Name = "buttonYes_MAB";
            buttonYes_MAB.Size = new Size(124, 47);
            buttonYes_MAB.TabIndex = 0;
            buttonYes_MAB.Text = "OK";
            buttonYes_MAB.UseVisualStyleBackColor = true;
            buttonYes_MAB.Click += buttonYes_MAB_Click;
            // 
            // labelInfo_MAB
            // 
            labelInfo_MAB.AutoSize = true;
            labelInfo_MAB.Location = new Point(185, 28);
            labelInfo_MAB.Name = "labelInfo_MAB";
            labelInfo_MAB.Size = new Size(393, 180);
            labelInfo_MAB.TabIndex = 1;
            labelInfo_MAB.Text = resources.GetString("labelInfo_MAB.Text");
            // 
            // pictureBoxAvatar_MAB
            // 
            pictureBoxAvatar_MAB.Image = Properties.Resources.CmpTZLigAAM;
            pictureBoxAvatar_MAB.Location = new Point(12, 28);
            pictureBoxAvatar_MAB.Name = "pictureBoxAvatar_MAB";
            pictureBoxAvatar_MAB.Size = new Size(158, 213);
            pictureBoxAvatar_MAB.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxAvatar_MAB.TabIndex = 2;
            pictureBoxAvatar_MAB.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(612, 306);
            Controls.Add(pictureBoxAvatar_MAB);
            Controls.Add(labelInfo_MAB);
            Controls.Add(buttonYes_MAB);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar_MAB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonYes_MAB;
        private Label labelInfo_MAB;
        private PictureBox pictureBoxAvatar_MAB;
    }
}