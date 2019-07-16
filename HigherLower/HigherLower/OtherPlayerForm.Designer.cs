namespace HigherLower
{
    partial class OtherPlayerForm
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
            this.MuchHigherButton = new System.Windows.Forms.Button();
            this.MuchLowerButton = new System.Windows.Forms.Button();
            this.LowerButton = new System.Windows.Forms.Button();
            this.HigherButton = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.FirstPlayerAnswerLabel = new System.Windows.Forms.Label();
            this.TextLabel = new System.Windows.Forms.Label();
            this.CurrentPlayerUserNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MuchHigherButton
            // 
            this.MuchHigherButton.Location = new System.Drawing.Point(620, 109);
            this.MuchHigherButton.Name = "MuchHigherButton";
            this.MuchHigherButton.Size = new System.Drawing.Size(86, 23);
            this.MuchHigherButton.TabIndex = 12;
            this.MuchHigherButton.Text = "Much Higher";
            this.MuchHigherButton.UseVisualStyleBackColor = true;
            this.MuchHigherButton.Click += new System.EventHandler(this.MuchHigherButton_Click);
            // 
            // MuchLowerButton
            // 
            this.MuchLowerButton.Location = new System.Drawing.Point(620, 236);
            this.MuchLowerButton.Name = "MuchLowerButton";
            this.MuchLowerButton.Size = new System.Drawing.Size(86, 23);
            this.MuchLowerButton.TabIndex = 11;
            this.MuchLowerButton.Text = "Much Lower";
            this.MuchLowerButton.UseVisualStyleBackColor = true;
            this.MuchLowerButton.Click += new System.EventHandler(this.MuchLowerButton_Click);
            // 
            // LowerButton
            // 
            this.LowerButton.Location = new System.Drawing.Point(620, 193);
            this.LowerButton.Name = "LowerButton";
            this.LowerButton.Size = new System.Drawing.Size(86, 23);
            this.LowerButton.TabIndex = 10;
            this.LowerButton.Text = "Lower";
            this.LowerButton.UseVisualStyleBackColor = true;
            this.LowerButton.Click += new System.EventHandler(this.LowerButton_Click);
            // 
            // HigherButton
            // 
            this.HigherButton.Location = new System.Drawing.Point(620, 149);
            this.HigherButton.Name = "HigherButton";
            this.HigherButton.Size = new System.Drawing.Size(86, 23);
            this.HigherButton.TabIndex = 9;
            this.HigherButton.Text = "Higher";
            this.HigherButton.UseVisualStyleBackColor = true;
            this.HigherButton.Click += new System.EventHandler(this.HigherButton_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(101, 64);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(0, 13);
            this.QuestionLabel.TabIndex = 14;
            // 
            // FirstPlayerAnswerLabel
            // 
            this.FirstPlayerAnswerLabel.AutoSize = true;
            this.FirstPlayerAnswerLabel.Location = new System.Drawing.Point(78, 154);
            this.FirstPlayerAnswerLabel.Name = "FirstPlayerAnswerLabel";
            this.FirstPlayerAnswerLabel.Size = new System.Drawing.Size(116, 13);
            this.FirstPlayerAnswerLabel.TabIndex = 15;
            this.FirstPlayerAnswerLabel.Text = "FirstPlayerAnswerLabel";
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(78, 109);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(76, 13);
            this.TextLabel.TabIndex = 16;
            this.TextLabel.Text = "Current Player:";
            // 
            // CurrentPlayerUserNameLabel
            // 
            this.CurrentPlayerUserNameLabel.AutoSize = true;
            this.CurrentPlayerUserNameLabel.Location = new System.Drawing.Point(158, 109);
            this.CurrentPlayerUserNameLabel.Name = "CurrentPlayerUserNameLabel";
            this.CurrentPlayerUserNameLabel.Size = new System.Drawing.Size(146, 13);
            this.CurrentPlayerUserNameLabel.TabIndex = 17;
            this.CurrentPlayerUserNameLabel.Text = "CurrentPlayerUserNameLabel";
            // 
            // OtherPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CurrentPlayerUserNameLabel);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.FirstPlayerAnswerLabel);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.MuchHigherButton);
            this.Controls.Add(this.MuchLowerButton);
            this.Controls.Add(this.LowerButton);
            this.Controls.Add(this.HigherButton);
            this.Name = "OtherPlayerForm";
            this.Text = "OtherPlayerForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button MuchHigherButton;
        private System.Windows.Forms.Button MuchLowerButton;
        private System.Windows.Forms.Button LowerButton;
        private System.Windows.Forms.Button HigherButton;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label FirstPlayerAnswerLabel;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Label CurrentPlayerUserNameLabel;
    }
}