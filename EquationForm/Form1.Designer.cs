namespace EquationForm
{
    partial class SolveForm
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
            this.tInput = new System.Windows.Forms.TextBox();
            this.bSolve = new System.Windows.Forms.Button();
            this.lHint = new System.Windows.Forms.Label();
            this.lResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tInput
            // 
            this.tInput.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tInput.Location = new System.Drawing.Point(12, 45);
            this.tInput.Name = "tInput";
            this.tInput.Size = new System.Drawing.Size(281, 33);
            this.tInput.TabIndex = 0;
            // 
            // bSolve
            // 
            this.bSolve.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bSolve.Location = new System.Drawing.Point(87, 183);
            this.bSolve.Name = "bSolve";
            this.bSolve.Size = new System.Drawing.Size(108, 35);
            this.bSolve.TabIndex = 1;
            this.bSolve.Text = "Solve";
            this.bSolve.UseVisualStyleBackColor = true;
            this.bSolve.Click += new System.EventHandler(this.bSolve_Click);
            // 
            // lHint
            // 
            this.lHint.AutoSize = true;
            this.lHint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lHint.Location = new System.Drawing.Point(12, 21);
            this.lHint.Name = "lHint";
            this.lHint.Size = new System.Drawing.Size(147, 21);
            this.lHint.TabIndex = 2;
            this.lHint.Text = "Enter your equation";
            // 
            // lResult
            // 
            this.lResult.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lResult.Location = new System.Drawing.Point(38, 96);
            this.lResult.Name = "lResult";
            this.lResult.Size = new System.Drawing.Size(217, 72);
            this.lResult.TabIndex = 3;
            this.lResult.Text = "Result is";
            this.lResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SolveForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(305, 369);
            this.Controls.Add(this.lResult);
            this.Controls.Add(this.lHint);
            this.Controls.Add(this.bSolve);
            this.Controls.Add(this.tInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SolveForm";
            this.Text = "EquationSolver";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tInput;
        private System.Windows.Forms.Button bSolve;
        private System.Windows.Forms.Label lHint;
        private System.Windows.Forms.Label lResult;
    }
}
