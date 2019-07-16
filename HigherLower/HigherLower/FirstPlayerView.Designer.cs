namespace HigherLower
{
    partial class FirstPlayerView
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
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.FirstPlayerSubmitButton = new System.Windows.Forms.Button();
            this.AnswerLabel = new System.Windows.Forms.Label();
            this.AnswerTextBox = new System.Windows.Forms.TextBox();
            this.TextLabel = new System.Windows.Forms.Label();
            this.CurrentPlayerUserNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.AutoSize = true;
            this.QuestionLabel.Location = new System.Drawing.Point(183, 69);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(70, 13);
            this.QuestionLabel.TabIndex = 0;
            this.QuestionLabel.Text = "QuestionText";
            // 
            // FirstPlayerSubmitButton
            // 
            this.FirstPlayerSubmitButton.Location = new System.Drawing.Point(388, 314);
            this.FirstPlayerSubmitButton.Name = "FirstPlayerSubmitButton";
            this.FirstPlayerSubmitButton.Size = new System.Drawing.Size(75, 23);
            this.FirstPlayerSubmitButton.TabIndex = 1;
            this.FirstPlayerSubmitButton.Text = "Submit";
            this.FirstPlayerSubmitButton.UseVisualStyleBackColor = true;
            this.FirstPlayerSubmitButton.Click += new System.EventHandler(this.FirstPlayerSubmitButtonClick);
            // 
            // AnswerLabel
            // 
            this.AnswerLabel.AutoSize = true;
            this.AnswerLabel.Location = new System.Drawing.Point(197, 234);
            this.AnswerLabel.Name = "AnswerLabel";
            this.AnswerLabel.Size = new System.Drawing.Size(45, 13);
            this.AnswerLabel.TabIndex = 2;
            this.AnswerLabel.Text = "Answer:";
            // 
            // AnswerTextBox
            // 
            this.AnswerTextBox.Location = new System.Drawing.Point(258, 227);
            this.AnswerTextBox.Name = "AnswerTextBox";
            this.AnswerTextBox.Size = new System.Drawing.Size(100, 20);
            this.AnswerTextBox.TabIndex = 3;
            // 
            // TextLabel
            // 
            this.TextLabel.AutoSize = true;
            this.TextLabel.Location = new System.Drawing.Point(183, 104);
            this.TextLabel.Name = "TextLabel";
            this.TextLabel.Size = new System.Drawing.Size(122, 13);
            this.TextLabel.TabIndex = 4;
            this.TextLabel.Text = "The Player answering is:";
            // 
            // CurrentPlayerUserNameLabel
            // 
            this.CurrentPlayerUserNameLabel.AutoSize = true;
            this.CurrentPlayerUserNameLabel.Location = new System.Drawing.Point(323, 104);
            this.CurrentPlayerUserNameLabel.Name = "CurrentPlayerUserNameLabel";
            this.CurrentPlayerUserNameLabel.Size = new System.Drawing.Size(146, 13);
            this.CurrentPlayerUserNameLabel.TabIndex = 5;
            this.CurrentPlayerUserNameLabel.Text = "CurrentPlayerUserNameLabel";
            // 
            // FirstPlayerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CurrentPlayerUserNameLabel);
            this.Controls.Add(this.TextLabel);
            this.Controls.Add(this.AnswerTextBox);
            this.Controls.Add(this.AnswerLabel);
            this.Controls.Add(this.FirstPlayerSubmitButton);
            this.Controls.Add(this.QuestionLabel);
            this.Name = "FirstPlayerView";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button FirstPlayerSubmitButton;
        private System.Windows.Forms.Label AnswerLabel;
        private System.Windows.Forms.TextBox AnswerTextBox;
        private System.Windows.Forms.Label TextLabel;
        private System.Windows.Forms.Label CurrentPlayerUserNameLabel;
    }
}

