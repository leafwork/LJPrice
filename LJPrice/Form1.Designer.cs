namespace LJPrice
{
    partial class MainForm
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
            lblRPI1 = new Label();
            lblInches1 = new Label();
            lblRPU1 = new Label();
            lblPPU1 = new Label();
            txtRPI1 = new TextBox();
            txtInches1 = new TextBox();
            txtRPU1 = new TextBox();
            txtPPU1 = new TextBox();
            txtPPU2 = new TextBox();
            txtRPU2 = new TextBox();
            txtInches2 = new TextBox();
            txtRPI2 = new TextBox();
            lblPPU2 = new Label();
            lblRPU2 = new Label();
            lblInches2 = new Label();
            lblRPI2 = new Label();
            buttonClear1 = new Button();
            buttonClear2 = new Button();
            lblRings1 = new Label();
            lblUnits1 = new Label();
            lblUnits2 = new Label();
            lblRings2 = new Label();
            lblTotalRings = new Label();
            lblFindings = new Label();
            txtFindings = new TextBox();
            txtLPR = new TextBox();
            lblLPR = new Label();
            lblMaterialCost = new Label();
            lblTotalLabor = new Label();
            txtOverhead = new TextBox();
            lblOverhead = new Label();
            lblFinalPrice = new Label();
            lblItemName = new Label();
            txtItemName = new TextBox();
            btnSave = new Button();
            btnLoad = new Button();
            SuspendLayout();
            // 
            // lblRPI1
            // 
            lblRPI1.AutoSize = true;
            lblRPI1.Location = new Point(20, 64);
            lblRPI1.Name = "lblRPI1";
            lblRPI1.Size = new Size(142, 25);
            lblRPI1.TabIndex = 0;
            lblRPI1.Text = "Rings Per Inch 1:";
            // 
            // lblInches1
            // 
            lblInches1.AutoSize = true;
            lblInches1.Location = new Point(20, 101);
            lblInches1.Name = "lblInches1";
            lblInches1.Size = new Size(81, 25);
            lblInches1.TabIndex = 1;
            lblInches1.Text = "Inches 1:";
            // 
            // lblRPU1
            // 
            lblRPU1.AutoSize = true;
            lblRPU1.Location = new Point(20, 138);
            lblRPU1.Name = "lblRPU1";
            lblRPU1.Size = new Size(141, 25);
            lblRPU1.TabIndex = 2;
            lblRPU1.Text = "Rings Per Unit 1:";
            // 
            // lblPPU1
            // 
            lblPPU1.AutoSize = true;
            lblPPU1.Location = new Point(21, 175);
            lblPPU1.Name = "lblPPU1";
            lblPPU1.Size = new Size(134, 25);
            lblPPU1.TabIndex = 3;
            lblPPU1.Text = "Price Per Unit 1:";
            // 
            // txtRPI1
            // 
            txtRPI1.Location = new Point(168, 61);
            txtRPI1.Name = "txtRPI1";
            txtRPI1.Size = new Size(76, 31);
            txtRPI1.TabIndex = 4;
            txtRPI1.Text = "0";
            txtRPI1.TextChanged += txtRPI1_TextChanged;
            // 
            // txtInches1
            // 
            txtInches1.Location = new Point(168, 98);
            txtInches1.Name = "txtInches1";
            txtInches1.Size = new Size(76, 31);
            txtInches1.TabIndex = 5;
            txtInches1.Text = "0";
            txtInches1.TextChanged += txtInches1_TextChanged;
            // 
            // txtRPU1
            // 
            txtRPU1.Location = new Point(168, 135);
            txtRPU1.Name = "txtRPU1";
            txtRPU1.Size = new Size(76, 31);
            txtRPU1.TabIndex = 6;
            txtRPU1.Text = "0";
            txtRPU1.TextChanged += txtRPU1_TextChanged;
            // 
            // txtPPU1
            // 
            txtPPU1.Location = new Point(168, 172);
            txtPPU1.Name = "txtPPU1";
            txtPPU1.Size = new Size(76, 31);
            txtPPU1.TabIndex = 7;
            txtPPU1.Text = "0";
            txtPPU1.TextChanged += txtPPU1_TextChanged;
            // 
            // txtPPU2
            // 
            txtPPU2.Location = new Point(396, 172);
            txtPPU2.Name = "txtPPU2";
            txtPPU2.Size = new Size(76, 31);
            txtPPU2.TabIndex = 15;
            txtPPU2.Text = "0";
            txtPPU2.TextChanged += txtPPU2_TextChanged;
            // 
            // txtRPU2
            // 
            txtRPU2.Location = new Point(396, 135);
            txtRPU2.Name = "txtRPU2";
            txtRPU2.Size = new Size(77, 31);
            txtRPU2.TabIndex = 14;
            txtRPU2.Text = "0";
            txtRPU2.TextChanged += txtRPU2_TextChanged;
            // 
            // txtInches2
            // 
            txtInches2.Location = new Point(397, 98);
            txtInches2.Name = "txtInches2";
            txtInches2.Size = new Size(76, 31);
            txtInches2.TabIndex = 13;
            txtInches2.Text = "0";
            txtInches2.TextChanged += txtInches2_TextChanged;
            // 
            // txtRPI2
            // 
            txtRPI2.Location = new Point(397, 61);
            txtRPI2.Name = "txtRPI2";
            txtRPI2.Size = new Size(76, 31);
            txtRPI2.TabIndex = 12;
            txtRPI2.Text = "0";
            txtRPI2.TextChanged += txtRPI2_TextChanged;
            // 
            // lblPPU2
            // 
            lblPPU2.AutoSize = true;
            lblPPU2.Location = new Point(249, 175);
            lblPPU2.Name = "lblPPU2";
            lblPPU2.Size = new Size(134, 25);
            lblPPU2.TabIndex = 11;
            lblPPU2.Text = "Price Per Unit 2:";
            // 
            // lblRPU2
            // 
            lblRPU2.AutoSize = true;
            lblRPU2.Location = new Point(249, 138);
            lblRPU2.Name = "lblRPU2";
            lblRPU2.Size = new Size(141, 25);
            lblRPU2.TabIndex = 10;
            lblRPU2.Text = "Rings Per Unit 2:";
            // 
            // lblInches2
            // 
            lblInches2.AutoSize = true;
            lblInches2.Location = new Point(250, 101);
            lblInches2.Name = "lblInches2";
            lblInches2.Size = new Size(81, 25);
            lblInches2.TabIndex = 9;
            lblInches2.Text = "Inches 2:";
            // 
            // lblRPI2
            // 
            lblRPI2.AutoSize = true;
            lblRPI2.Location = new Point(250, 64);
            lblRPI2.Name = "lblRPI2";
            lblRPI2.Size = new Size(142, 25);
            lblRPI2.TabIndex = 8;
            lblRPI2.Text = "Rings Per Inch 2:";
            // 
            // buttonClear1
            // 
            buttonClear1.Location = new Point(179, 209);
            buttonClear1.Name = "buttonClear1";
            buttonClear1.Size = new Size(64, 32);
            buttonClear1.TabIndex = 16;
            buttonClear1.Text = "Clear";
            buttonClear1.UseVisualStyleBackColor = true;
            buttonClear1.Click += buttonClear1_Click;
            // 
            // buttonClear2
            // 
            buttonClear2.Location = new Point(409, 209);
            buttonClear2.Name = "buttonClear2";
            buttonClear2.Size = new Size(64, 32);
            buttonClear2.TabIndex = 17;
            buttonClear2.Text = "Clear";
            buttonClear2.UseVisualStyleBackColor = true;
            buttonClear2.Click += buttonClear2_Click;
            // 
            // lblRings1
            // 
            lblRings1.AutoSize = true;
            lblRings1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRings1.Location = new Point(20, 206);
            lblRings1.Name = "lblRings1";
            lblRings1.Size = new Size(94, 25);
            lblRings1.TabIndex = 18;
            lblRings1.Text = "Rings 1: 0";
            // 
            // lblUnits1
            // 
            lblUnits1.AutoSize = true;
            lblUnits1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUnits1.Location = new Point(20, 231);
            lblUnits1.Name = "lblUnits1";
            lblUnits1.Size = new Size(91, 25);
            lblUnits1.TabIndex = 19;
            lblUnits1.Text = "Units 1: 0";
            // 
            // lblUnits2
            // 
            lblUnits2.AutoSize = true;
            lblUnits2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblUnits2.Location = new Point(249, 231);
            lblUnits2.Name = "lblUnits2";
            lblUnits2.Size = new Size(91, 25);
            lblUnits2.TabIndex = 21;
            lblUnits2.Text = "Units 2: 0";
            // 
            // lblRings2
            // 
            lblRings2.AutoSize = true;
            lblRings2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRings2.Location = new Point(250, 206);
            lblRings2.Name = "lblRings2";
            lblRings2.Size = new Size(94, 25);
            lblRings2.TabIndex = 20;
            lblRings2.Text = "Rings 2: 0";
            // 
            // lblTotalRings
            // 
            lblTotalRings.AutoSize = true;
            lblTotalRings.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTotalRings.Location = new Point(347, 275);
            lblTotalRings.Name = "lblTotalRings";
            lblTotalRings.Size = new Size(126, 25);
            lblTotalRings.TabIndex = 22;
            lblTotalRings.Text = "Total Rings: 0";
            // 
            // lblFindings
            // 
            lblFindings.AutoSize = true;
            lblFindings.Location = new Point(21, 278);
            lblFindings.Name = "lblFindings";
            lblFindings.Size = new Size(83, 25);
            lblFindings.TabIndex = 23;
            lblFindings.Text = "Findings:";
            // 
            // txtFindings
            // 
            txtFindings.Location = new Point(168, 275);
            txtFindings.Name = "txtFindings";
            txtFindings.Size = new Size(77, 31);
            txtFindings.TabIndex = 24;
            txtFindings.Text = "0";
            txtFindings.TextChanged += txtFindings_TextChanged;
            // 
            // txtLPR
            // 
            txtLPR.Location = new Point(167, 312);
            txtLPR.Name = "txtLPR";
            txtLPR.Size = new Size(77, 31);
            txtLPR.TabIndex = 26;
            txtLPR.Text = "0.12";
            txtLPR.TextChanged += txtLPR_TextChanged;
            // 
            // lblLPR
            // 
            lblLPR.AutoSize = true;
            lblLPR.Location = new Point(20, 315);
            lblLPR.Name = "lblLPR";
            lblLPR.Size = new Size(131, 25);
            lblLPR.TabIndex = 25;
            lblLPR.Text = "Labor Per Ring:";
            // 
            // lblMaterialCost
            // 
            lblMaterialCost.AutoSize = true;
            lblMaterialCost.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMaterialCost.Location = new Point(287, 300);
            lblMaterialCost.Name = "lblMaterialCost";
            lblMaterialCost.Size = new Size(243, 32);
            lblMaterialCost.TabIndex = 27;
            lblMaterialCost.Text = "Material Cost: $0.00";
            // 
            // lblTotalLabor
            // 
            lblTotalLabor.AutoSize = true;
            lblTotalLabor.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalLabor.Location = new Point(310, 331);
            lblTotalLabor.Name = "lblTotalLabor";
            lblTotalLabor.Size = new Size(220, 32);
            lblTotalLabor.TabIndex = 28;
            lblTotalLabor.Text = "Total Labor: $0.00";
            // 
            // txtOverhead
            // 
            txtOverhead.Location = new Point(167, 349);
            txtOverhead.Name = "txtOverhead";
            txtOverhead.Size = new Size(77, 31);
            txtOverhead.TabIndex = 30;
            txtOverhead.Text = "15";
            txtOverhead.TextChanged += txtOverhead_TextChanged;
            // 
            // lblOverhead
            // 
            lblOverhead.AutoSize = true;
            lblOverhead.Location = new Point(20, 352);
            lblOverhead.Name = "lblOverhead";
            lblOverhead.Size = new Size(113, 25);
            lblOverhead.TabIndex = 29;
            lblOverhead.Text = "Overhead %:";
            // 
            // lblFinalPrice
            // 
            lblFinalPrice.AutoSize = true;
            lblFinalPrice.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFinalPrice.Location = new Point(277, 361);
            lblFinalPrice.Name = "lblFinalPrice";
            lblFinalPrice.Size = new Size(273, 45);
            lblFinalPrice.TabIndex = 31;
            lblFinalPrice.Text = "Final Price: $0.00";
            // 
            // lblItemName
            // 
            lblItemName.AutoSize = true;
            lblItemName.Location = new Point(21, 15);
            lblItemName.Name = "lblItemName";
            lblItemName.Size = new Size(104, 25);
            lblItemName.TabIndex = 32;
            lblItemName.Text = "Item Name:";
            // 
            // txtItemName
            // 
            txtItemName.Location = new Point(131, 12);
            txtItemName.Name = "txtItemName";
            txtItemName.Size = new Size(341, 31);
            txtItemName.TabIndex = 33;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(313, 424);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(160, 48);
            btnSave.TabIndex = 34;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(21, 425);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(160, 48);
            btnLoad.TabIndex = 35;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(624, 491);
            Controls.Add(btnLoad);
            Controls.Add(btnSave);
            Controls.Add(txtItemName);
            Controls.Add(lblItemName);
            Controls.Add(lblFinalPrice);
            Controls.Add(txtOverhead);
            Controls.Add(lblOverhead);
            Controls.Add(lblTotalLabor);
            Controls.Add(lblMaterialCost);
            Controls.Add(txtLPR);
            Controls.Add(lblLPR);
            Controls.Add(txtFindings);
            Controls.Add(lblFindings);
            Controls.Add(lblTotalRings);
            Controls.Add(lblUnits2);
            Controls.Add(lblRings2);
            Controls.Add(lblUnits1);
            Controls.Add(lblRings1);
            Controls.Add(buttonClear2);
            Controls.Add(buttonClear1);
            Controls.Add(txtPPU2);
            Controls.Add(txtRPU2);
            Controls.Add(txtInches2);
            Controls.Add(txtRPI2);
            Controls.Add(lblPPU2);
            Controls.Add(lblRPU2);
            Controls.Add(lblInches2);
            Controls.Add(lblRPI2);
            Controls.Add(txtPPU1);
            Controls.Add(txtRPU1);
            Controls.Add(txtInches1);
            Controls.Add(txtRPI1);
            Controls.Add(lblPPU1);
            Controls.Add(lblRPU1);
            Controls.Add(lblInches1);
            Controls.Add(lblRPI1);
            Name = "MainForm";
            Padding = new Padding(0, 0, 16, 16);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LJPrice";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblRPI1;
        private Label lblInches1;
        private Label lblRPU1;
        private Label lblPPU1;
        private TextBox txtRPI1;
        private TextBox txtInches1;
        private TextBox txtRPU1;
        private TextBox txtPPU1;
        private TextBox txtPPU2;
        private TextBox txtRPU2;
        private TextBox txtInches2;
        private TextBox txtRPI2;
        private Label lblPPU2;
        private Label lblRPU2;
        private Label lblInches2;
        private Label lblRPI2;
        private Button buttonClear1;
        private Button buttonClear2;
        private Label lblRings1;
        private Label lblUnits1;
        private Label lblUnits2;
        private Label lblRings2;
        private Label lblTotalRings;
        private Label lblFindings;
        private TextBox txtFindings;
        private TextBox txtLPR;
        private Label lblLPR;
        private Label lblMaterialCost;
        private Label lblTotalLabor;
        private TextBox txtOverhead;
        private Label lblOverhead;
        private Label lblFinalPrice;
        private Label lblItemName;
        private TextBox txtItemName;
        private Button btnSave;
        private Button btnLoad;
    }
}
