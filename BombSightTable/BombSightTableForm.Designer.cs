﻿namespace BombSightTable
{
    partial class BombSightTableForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.calcButton = new System.Windows.Forms.Button();
            this.inputApproachHeadingMasked = new System.Windows.Forms.MaskedTextBox();
            this.inputAltitudeMasked = new System.Windows.Forms.MaskedTextBox();
            this.inputWindHeadingMasked = new System.Windows.Forms.MaskedTextBox();
            this.inputWindSpeedMasked = new System.Windows.Forms.MaskedTextBox();
            this.resultHeadingOutput = new System.Windows.Forms.TextBox();
            this.outputLabelHeading = new System.Windows.Forms.Label();
            this.outputLabelCorrection = new System.Windows.Forms.Label();
            this.outputLabelSide = new System.Windows.Forms.Label();
            this.resultCorrectionOutput = new System.Windows.Forms.TextBox();
            this.resultSideOutput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Approach Heading:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Altitude:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Wind Heading:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(12, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Wind Speed:";
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(118, 169);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(69, 23);
            this.calcButton.TabIndex = 14;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // inputApproachHeadingMasked
            // 
            this.inputApproachHeadingMasked.Location = new System.Drawing.Point(118, 28);
            this.inputApproachHeadingMasked.Mask = "000";
            this.inputApproachHeadingMasked.Name = "inputApproachHeadingMasked";
            this.inputApproachHeadingMasked.PromptChar = ' ';
            this.inputApproachHeadingMasked.Size = new System.Drawing.Size(68, 20);
            this.inputApproachHeadingMasked.TabIndex = 10;
            this.inputApproachHeadingMasked.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox2_MaskInputRejected);
            // 
            // inputAltitudeMasked
            // 
            this.inputAltitudeMasked.Location = new System.Drawing.Point(118, 66);
            this.inputAltitudeMasked.Mask = "00000";
            this.inputAltitudeMasked.Name = "inputAltitudeMasked";
            this.inputAltitudeMasked.PromptChar = ' ';
            this.inputAltitudeMasked.Size = new System.Drawing.Size(68, 20);
            this.inputAltitudeMasked.TabIndex = 11;
            this.inputAltitudeMasked.ValidatingType = typeof(int);
            this.inputAltitudeMasked.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.inputAltitudeMasked_MaskInputRejected);
            // 
            // inputWindHeadingMasked
            // 
            this.inputWindHeadingMasked.Location = new System.Drawing.Point(119, 104);
            this.inputWindHeadingMasked.Mask = "000";
            this.inputWindHeadingMasked.Name = "inputWindHeadingMasked";
            this.inputWindHeadingMasked.PromptChar = ' ';
            this.inputWindHeadingMasked.Size = new System.Drawing.Size(68, 20);
            this.inputWindHeadingMasked.TabIndex = 12;
            // 
            // inputWindSpeedMasked
            // 
            this.inputWindSpeedMasked.Location = new System.Drawing.Point(119, 142);
            this.inputWindSpeedMasked.Mask = "00";
            this.inputWindSpeedMasked.Name = "inputWindSpeedMasked";
            this.inputWindSpeedMasked.PromptChar = ' ';
            this.inputWindSpeedMasked.Size = new System.Drawing.Size(68, 20);
            this.inputWindSpeedMasked.TabIndex = 13;
            // 
            // resultHeadingOutput
            // 
            this.resultHeadingOutput.Location = new System.Drawing.Point(197, 28);
            this.resultHeadingOutput.Multiline = true;
            this.resultHeadingOutput.Name = "resultHeadingOutput";
            this.resultHeadingOutput.Size = new System.Drawing.Size(47, 163);
            this.resultHeadingOutput.TabIndex = 15;
            this.resultHeadingOutput.TabStop = false;
            this.resultHeadingOutput.Visible = false;
            this.resultHeadingOutput.TextChanged += new System.EventHandler(this.resultOutputTextContainer_TextChanged);
            // 
            // outputLabelHeading
            // 
            this.outputLabelHeading.AutoSize = true;
            this.outputLabelHeading.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.outputLabelHeading.Location = new System.Drawing.Point(197, 13);
            this.outputLabelHeading.Name = "outputLabelHeading";
            this.outputLabelHeading.Size = new System.Drawing.Size(47, 13);
            this.outputLabelHeading.TabIndex = 17;
            this.outputLabelHeading.Text = "Heading";
            this.outputLabelHeading.Visible = false;
            // 
            // outputLabelCorrection
            // 
            this.outputLabelCorrection.AutoSize = true;
            this.outputLabelCorrection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.outputLabelCorrection.Location = new System.Drawing.Point(252, 13);
            this.outputLabelCorrection.Name = "outputLabelCorrection";
            this.outputLabelCorrection.Size = new System.Drawing.Size(55, 13);
            this.outputLabelCorrection.TabIndex = 18;
            this.outputLabelCorrection.Text = "Correction";
            this.outputLabelCorrection.Visible = false;
            // 
            // outputLabelSide
            // 
            this.outputLabelSide.AutoSize = true;
            this.outputLabelSide.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.outputLabelSide.Location = new System.Drawing.Point(317, 13);
            this.outputLabelSide.Name = "outputLabelSide";
            this.outputLabelSide.Size = new System.Drawing.Size(40, 13);
            this.outputLabelSide.TabIndex = 19;
            this.outputLabelSide.Text = "to Side";
            this.outputLabelSide.Visible = false;
            this.outputLabelSide.Click += new System.EventHandler(this.outputLabelSide_Click);
            // 
            // resultCorrectionOutput
            // 
            this.resultCorrectionOutput.Location = new System.Drawing.Point(255, 29);
            this.resultCorrectionOutput.Multiline = true;
            this.resultCorrectionOutput.Name = "resultCorrectionOutput";
            this.resultCorrectionOutput.Size = new System.Drawing.Size(47, 163);
            this.resultCorrectionOutput.TabIndex = 20;
            this.resultCorrectionOutput.TabStop = false;
            this.resultCorrectionOutput.Visible = false;
            // 
            // resultSideOutput
            // 
            this.resultSideOutput.Location = new System.Drawing.Point(313, 29);
            this.resultSideOutput.Multiline = true;
            this.resultSideOutput.Name = "resultSideOutput";
            this.resultSideOutput.Size = new System.Drawing.Size(47, 163);
            this.resultSideOutput.TabIndex = 21;
            this.resultSideOutput.TabStop = false;
            this.resultSideOutput.Visible = false;
            // 
            // BombSightTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(196, 203);
            this.Controls.Add(this.resultSideOutput);
            this.Controls.Add(this.resultCorrectionOutput);
            this.Controls.Add(this.outputLabelSide);
            this.Controls.Add(this.outputLabelCorrection);
            this.Controls.Add(this.outputLabelHeading);
            this.Controls.Add(this.resultHeadingOutput);
            this.Controls.Add(this.inputWindSpeedMasked);
            this.Controls.Add(this.inputWindHeadingMasked);
            this.Controls.Add(this.inputAltitudeMasked);
            this.Controls.Add(this.inputApproachHeadingMasked);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "BombSightTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InputParametersForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button calcButton;
        private System.Windows.Forms.MaskedTextBox inputApproachHeadingMasked;
        private System.Windows.Forms.MaskedTextBox inputAltitudeMasked;
        private System.Windows.Forms.MaskedTextBox inputWindHeadingMasked;
        private System.Windows.Forms.MaskedTextBox inputWindSpeedMasked;
        private System.Windows.Forms.TextBox resultHeadingOutput;
        private System.Windows.Forms.Label outputLabelHeading;
        private System.Windows.Forms.Label outputLabelCorrection;
        private System.Windows.Forms.Label outputLabelSide;
        private System.Windows.Forms.TextBox resultCorrectionOutput;
        private System.Windows.Forms.TextBox resultSideOutput;
    }
}

