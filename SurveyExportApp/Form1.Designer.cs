
namespace SurveyExportApp
{
    partial class Form1
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
            this.answersDataGrid = new System.Windows.Forms.DataGridView();
            this.imagesDataGrid = new System.Windows.Forms.DataGridView();
            this.exportButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.answersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // answersDataGrid
            // 
            this.answersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.answersDataGrid.Location = new System.Drawing.Point(13, 13);
            this.answersDataGrid.Name = "answersDataGrid";
            this.answersDataGrid.Size = new System.Drawing.Size(561, 260);
            this.answersDataGrid.TabIndex = 0;
            // 
            // imagesDataGrid
            // 
            this.imagesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imagesDataGrid.Location = new System.Drawing.Point(632, 12);
            this.imagesDataGrid.Name = "imagesDataGrid";
            this.imagesDataGrid.Size = new System.Drawing.Size(586, 261);
            this.imagesDataGrid.TabIndex = 1;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(28, 439);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(75, 23);
            this.exportButton.TabIndex = 2;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 575);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.imagesDataGrid);
            this.Controls.Add(this.answersDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.answersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView answersDataGrid;
        private System.Windows.Forms.DataGridView imagesDataGrid;
        private System.Windows.Forms.Button exportButton;
    }
}

