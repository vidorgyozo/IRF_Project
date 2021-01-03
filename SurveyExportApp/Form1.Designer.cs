
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
            this.answerLabel = new System.Windows.Forms.Label();
            this.imageLabel = new System.Windows.Forms.Label();
            this.regionBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.answersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // answersDataGrid
            // 
            this.answersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.answersDataGrid.Location = new System.Drawing.Point(12, 36);
            this.answersDataGrid.Name = "answersDataGrid";
            this.answersDataGrid.Size = new System.Drawing.Size(769, 428);
            this.answersDataGrid.TabIndex = 0;
            // 
            // imagesDataGrid
            // 
            this.imagesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imagesDataGrid.Location = new System.Drawing.Point(800, 36);
            this.imagesDataGrid.Name = "imagesDataGrid";
            this.imagesDataGrid.Size = new System.Drawing.Size(418, 428);
            this.imagesDataGrid.TabIndex = 1;
            // 
            // exportButton
            // 
            this.exportButton.Location = new System.Drawing.Point(1115, 525);
            this.exportButton.Name = "exportButton";
            this.exportButton.Size = new System.Drawing.Size(103, 38);
            this.exportButton.TabIndex = 2;
            this.exportButton.Text = "Export";
            this.exportButton.UseVisualStyleBackColor = true;
            // 
            // answerLabel
            // 
            this.answerLabel.AutoSize = true;
            this.answerLabel.Location = new System.Drawing.Point(13, 17);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(47, 13);
            this.answerLabel.TabIndex = 3;
            this.answerLabel.Text = "Answers";
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(800, 17);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(41, 13);
            this.imageLabel.TabIndex = 4;
            this.imageLabel.Text = "Images";
            // 
            // regionBox
            // 
            this.regionBox.FormattingEnabled = true;
            this.regionBox.Location = new System.Drawing.Point(12, 506);
            this.regionBox.Name = "regionBox";
            this.regionBox.Size = new System.Drawing.Size(121, 21);
            this.regionBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 575);
            this.Controls.Add(this.regionBox);
            this.Controls.Add(this.imageLabel);
            this.Controls.Add(this.answerLabel);
            this.Controls.Add(this.exportButton);
            this.Controls.Add(this.imagesDataGrid);
            this.Controls.Add(this.answersDataGrid);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.answersDataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView answersDataGrid;
        private System.Windows.Forms.DataGridView imagesDataGrid;
        private System.Windows.Forms.Button exportButton;
        private System.Windows.Forms.Label answerLabel;
        private System.Windows.Forms.Label imageLabel;
        private System.Windows.Forms.ComboBox regionBox;
    }
}

