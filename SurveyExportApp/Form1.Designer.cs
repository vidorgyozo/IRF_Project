
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
            this.avgLabel = new System.Windows.Forms.Label();
            this.avgLabel2 = new System.Windows.Forms.Label();
            this.calcAvgButton = new System.Windows.Forms.Button();
            this.avgResultLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.answersDataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imagesDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // answersDataGrid
            // 
            this.answersDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.answersDataGrid.Location = new System.Drawing.Point(12, 36);
            this.answersDataGrid.Name = "answersDataGrid";
            this.answersDataGrid.Size = new System.Drawing.Size(721, 428);
            this.answersDataGrid.TabIndex = 0;
            // 
            // imagesDataGrid
            // 
            this.imagesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.imagesDataGrid.Location = new System.Drawing.Point(751, 36);
            this.imagesDataGrid.Name = "imagesDataGrid";
            this.imagesDataGrid.Size = new System.Drawing.Size(467, 428);
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
            this.answerLabel.Location = new System.Drawing.Point(9, 17);
            this.answerLabel.Name = "answerLabel";
            this.answerLabel.Size = new System.Drawing.Size(47, 13);
            this.answerLabel.TabIndex = 3;
            this.answerLabel.Text = "Answers";
            // 
            // imageLabel
            // 
            this.imageLabel.AutoSize = true;
            this.imageLabel.Location = new System.Drawing.Point(748, 17);
            this.imageLabel.Name = "imageLabel";
            this.imageLabel.Size = new System.Drawing.Size(41, 13);
            this.imageLabel.TabIndex = 4;
            this.imageLabel.Text = "Images";
            // 
            // regionBox
            // 
            this.regionBox.FormattingEnabled = true;
            this.regionBox.Location = new System.Drawing.Point(172, 499);
            this.regionBox.Name = "regionBox";
            this.regionBox.Size = new System.Drawing.Size(121, 21);
            this.regionBox.TabIndex = 5;
            // 
            // avgLabel
            // 
            this.avgLabel.AutoSize = true;
            this.avgLabel.Location = new System.Drawing.Point(13, 502);
            this.avgLabel.Name = "avgLabel";
            this.avgLabel.Size = new System.Drawing.Size(153, 13);
            this.avgLabel.TabIndex = 6;
            this.avgLabel.Text = "Average of image ratings in the";
            // 
            // avgLabel2
            // 
            this.avgLabel2.AutoSize = true;
            this.avgLabel2.Location = new System.Drawing.Point(300, 502);
            this.avgLabel2.Name = "avgLabel2";
            this.avgLabel2.Size = new System.Drawing.Size(39, 13);
            this.avgLabel2.TabIndex = 7;
            this.avgLabel2.Text = "region:";
            // 
            // calcAvgButton
            // 
            this.calcAvgButton.Location = new System.Drawing.Point(264, 526);
            this.calcAvgButton.Name = "calcAvgButton";
            this.calcAvgButton.Size = new System.Drawing.Size(75, 23);
            this.calcAvgButton.TabIndex = 8;
            this.calcAvgButton.Text = "Calculate";
            this.calcAvgButton.UseVisualStyleBackColor = true;
            // 
            // avgResultLabel
            // 
            this.avgResultLabel.AutoSize = true;
            this.avgResultLabel.Location = new System.Drawing.Point(346, 506);
            this.avgResultLabel.Name = "avgResultLabel";
            this.avgResultLabel.Size = new System.Drawing.Size(0, 13);
            this.avgResultLabel.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 575);
            this.Controls.Add(this.avgResultLabel);
            this.Controls.Add(this.calcAvgButton);
            this.Controls.Add(this.avgLabel2);
            this.Controls.Add(this.avgLabel);
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
        private System.Windows.Forms.Label avgLabel;
        private System.Windows.Forms.Label avgLabel2;
        private System.Windows.Forms.Button calcAvgButton;
        private System.Windows.Forms.Label avgResultLabel;
    }
}

