namespace BasicQueuing
{
    partial class QueuingNumberForm
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
            this.lblNowServing = new System.Windows.Forms.Label();
            this.lblServingNumber = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNowServing
            // 
            this.lblNowServing.AutoSize = true;
            this.lblNowServing.BackColor = System.Drawing.Color.Transparent;
            this.lblNowServing.Font = new System.Drawing.Font("Lucida Fax", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNowServing.Location = new System.Drawing.Point(43, 9);
            this.lblNowServing.Name = "lblNowServing";
            this.lblNowServing.Size = new System.Drawing.Size(165, 24);
            this.lblNowServing.TabIndex = 0;
            this.lblNowServing.Text = "NOW SERVING";
            // 
            // lblServingNumber
            // 
            this.lblServingNumber.AutoSize = true;
            this.lblServingNumber.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblServingNumber.Location = new System.Drawing.Point(116, 42);
            this.lblServingNumber.Name = "lblServingNumber";
            this.lblServingNumber.Size = new System.Drawing.Size(25, 34);
            this.lblServingNumber.TabIndex = 1;
            this.lblServingNumber.Text = "-";
            // 
            // QueuingNumberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(250, 122);
            this.Controls.Add(this.lblServingNumber);
            this.Controls.Add(this.lblNowServing);
            this.Name = "QueuingNumberForm";
            this.Text = "QueuingNumberForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNowServing;
        private System.Windows.Forms.Label lblServingNumber;
    }
}