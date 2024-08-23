namespace piz
{
    partial class Form1
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
            label1 = new Label();
            rbSmall = new RadioButton();
            rbMoyen = new RadioButton();
            rbLarge = new RadioButton();
            rbThinCrust = new RadioButton();
            rbThinkCrust = new RadioButton();
            rbEatIn = new RadioButton();
            rbTakeOut = new RadioButton();
            chkExtraSheese = new CheckBox();
            chkMushrooms = new CheckBox();
            chkTomatoes = new CheckBox();
            chkOnion = new CheckBox();
            chkOlive = new CheckBox();
            chkGreenPaper = new CheckBox();
            gbTopping = new GroupBox();
            gbSize = new GroupBox();
            gbCrustType = new GroupBox();
            gbWhereToEat = new GroupBox();
            label3 = new Label();
            label5 = new Label();
            label7 = new Label();
            label9 = new Label();
            label11 = new Label();
            lbTotalPrice = new Label();
            btOrderPizza = new Button();
            btReset = new Button();
            lbSize = new Label();
            lbToppings = new Label();
            lbCrusType = new Label();
            lbWhereToEat = new Label();
            gbTopping.SuspendLayout();
            gbSize.SuspendLayout();
            gbCrustType.SuspendLayout();
            gbWhereToEat.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Showcard Gothic", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(192, 0, 0);
            label1.Location = new Point(230, 9);
            label1.Name = "label1";
            label1.Size = new Size(561, 74);
            label1.TabIndex = 0;
            label1.Text = "Make Your Pizza";
            // 
            // rbSmall
            // 
            rbSmall.AutoSize = true;
            rbSmall.Location = new Point(32, 30);
            rbSmall.Name = "rbSmall";
            rbSmall.Size = new Size(67, 24);
            rbSmall.TabIndex = 1;
            rbSmall.TabStop = true;
            rbSmall.Tag = "20";
            rbSmall.Text = "Small";
            rbSmall.UseVisualStyleBackColor = true;
            rbSmall.CheckedChanged += rbSmall_CheckedChanged;
            // 
            // rbMoyen
            // 
            rbMoyen.AutoSize = true;
            rbMoyen.Checked = true;
            rbMoyen.Location = new Point(32, 78);
            rbMoyen.Name = "rbMoyen";
            rbMoyen.Size = new Size(75, 24);
            rbMoyen.TabIndex = 2;
            rbMoyen.TabStop = true;
            rbMoyen.Tag = "30";
            rbMoyen.Text = "Moyen";
            rbMoyen.UseVisualStyleBackColor = true;
            rbMoyen.CheckedChanged += rbMoyen_CheckedChanged;
            // 
            // rbLarge
            // 
            rbLarge.AutoSize = true;
            rbLarge.Location = new Point(32, 126);
            rbLarge.Name = "rbLarge";
            rbLarge.Size = new Size(67, 24);
            rbLarge.TabIndex = 3;
            rbLarge.TabStop = true;
            rbLarge.Tag = "40";
            rbLarge.Text = "Large";
            rbLarge.UseVisualStyleBackColor = true;
            rbLarge.CheckedChanged += rbLarge_CheckedChanged_1;
            // 
            // rbThinCrust
            // 
            rbThinCrust.AutoSize = true;
            rbThinCrust.Checked = true;
            rbThinCrust.Location = new Point(18, 26);
            rbThinCrust.Name = "rbThinCrust";
            rbThinCrust.Size = new Size(95, 24);
            rbThinCrust.TabIndex = 4;
            rbThinCrust.TabStop = true;
            rbThinCrust.Tag = "10";
            rbThinCrust.Text = "Thin Crust";
            rbThinCrust.UseVisualStyleBackColor = true;
            rbThinCrust.CheckedChanged += rbThinCrust_CheckedChanged_1;
            // 
            // rbThinkCrust
            // 
            rbThinkCrust.AutoSize = true;
            rbThinkCrust.Location = new Point(18, 56);
            rbThinkCrust.Name = "rbThinkCrust";
            rbThinkCrust.Size = new Size(102, 24);
            rbThinkCrust.TabIndex = 5;
            rbThinkCrust.Tag = "20";
            rbThinkCrust.Text = "Think Crust";
            rbThinkCrust.UseVisualStyleBackColor = true;
            rbThinkCrust.CheckedChanged += rbThinkCrust_CheckedChanged;
            // 
            // rbEatIn
            // 
            rbEatIn.AutoSize = true;
            rbEatIn.Checked = true;
            rbEatIn.Location = new Point(21, 41);
            rbEatIn.Name = "rbEatIn";
            rbEatIn.Size = new Size(67, 24);
            rbEatIn.TabIndex = 6;
            rbEatIn.TabStop = true;
            rbEatIn.Tag = "0";
            rbEatIn.Text = "Eat In";
            rbEatIn.UseVisualStyleBackColor = true;
            rbEatIn.CheckedChanged += rbEatIn_CheckedChanged_1;
            // 
            // rbTakeOut
            // 
            rbTakeOut.AutoSize = true;
            rbTakeOut.Location = new Point(170, 41);
            rbTakeOut.Name = "rbTakeOut";
            rbTakeOut.Size = new Size(87, 24);
            rbTakeOut.TabIndex = 7;
            rbTakeOut.Tag = "0";
            rbTakeOut.Text = "Take Out";
            rbTakeOut.UseVisualStyleBackColor = true;
            rbTakeOut.CheckedChanged += rbTakeOut_CheckedChanged_1;
            // 
            // chkExtraSheese
            // 
            chkExtraSheese.AutoSize = true;
            chkExtraSheese.Location = new Point(21, 30);
            chkExtraSheese.Name = "chkExtraSheese";
            chkExtraSheese.Size = new Size(114, 24);
            chkExtraSheese.TabIndex = 8;
            chkExtraSheese.Tag = "10";
            chkExtraSheese.Text = "Extra Sheese";
            chkExtraSheese.UseVisualStyleBackColor = true;
            chkExtraSheese.CheckedChanged += chkExtraSheese_CheckedChanged;
            // 
            // chkMushrooms
            // 
            chkMushrooms.AutoSize = true;
            chkMushrooms.Location = new Point(21, 78);
            chkMushrooms.Name = "chkMushrooms";
            chkMushrooms.Size = new Size(102, 24);
            chkMushrooms.TabIndex = 9;
            chkMushrooms.Tag = "10";
            chkMushrooms.Text = "Mushroom";
            chkMushrooms.UseVisualStyleBackColor = true;
            chkMushrooms.CheckedChanged += chkMushrooms_CheckedChanged_1;
            // 
            // chkTomatoes
            // 
            chkTomatoes.AutoSize = true;
            chkTomatoes.Location = new Point(21, 126);
            chkTomatoes.Name = "chkTomatoes";
            chkTomatoes.Size = new Size(96, 24);
            chkTomatoes.TabIndex = 10;
            chkTomatoes.Tag = "10";
            chkTomatoes.Text = "Tomatoes";
            chkTomatoes.UseVisualStyleBackColor = true;
            chkTomatoes.CheckedChanged += chkTomatoes_CheckedChanged;
            // 
            // chkOnion
            // 
            chkOnion.AutoSize = true;
            chkOnion.Location = new Point(170, 30);
            chkOnion.Name = "chkOnion";
            chkOnion.Size = new Size(71, 24);
            chkOnion.TabIndex = 11;
            chkOnion.Tag = "10";
            chkOnion.Text = "Onion";
            chkOnion.UseVisualStyleBackColor = true;
            chkOnion.CheckedChanged += chkOnion_CheckedChanged_1;
            // 
            // chkOlive
            // 
            chkOlive.AutoSize = true;
            chkOlive.Location = new Point(170, 78);
            chkOlive.Name = "chkOlive";
            chkOlive.Size = new Size(65, 24);
            chkOlive.TabIndex = 12;
            chkOlive.Tag = "10";
            chkOlive.Text = "Olive";
            chkOlive.UseVisualStyleBackColor = true;
            chkOlive.CheckedChanged += chkOlive_CheckedChanged;
            // 
            // chkGreenPaper
            // 
            chkGreenPaper.AutoSize = true;
            chkGreenPaper.Location = new Point(170, 126);
            chkGreenPaper.Name = "chkGreenPaper";
            chkGreenPaper.Size = new Size(120, 24);
            chkGreenPaper.TabIndex = 13;
            chkGreenPaper.Tag = "10";
            chkGreenPaper.Text = "Green Pepper";
            chkGreenPaper.UseVisualStyleBackColor = true;
            chkGreenPaper.CheckedChanged += chkGreenPaper_CheckedChanged;
            // 
            // gbTopping
            // 
            gbTopping.Controls.Add(chkGreenPaper);
            gbTopping.Controls.Add(chkOlive);
            gbTopping.Controls.Add(chkOnion);
            gbTopping.Controls.Add(chkTomatoes);
            gbTopping.Controls.Add(chkMushrooms);
            gbTopping.Controls.Add(chkExtraSheese);
            gbTopping.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            gbTopping.Location = new Point(339, 125);
            gbTopping.Name = "gbTopping";
            gbTopping.Size = new Size(296, 169);
            gbTopping.TabIndex = 14;
            gbTopping.TabStop = false;
            gbTopping.Text = "Topping";
            // 
            // gbSize
            // 
            gbSize.Controls.Add(rbLarge);
            gbSize.Controls.Add(rbMoyen);
            gbSize.Controls.Add(rbSmall);
            gbSize.Location = new Point(41, 125);
            gbSize.Name = "gbSize";
            gbSize.Size = new Size(176, 169);
            gbSize.TabIndex = 15;
            gbSize.TabStop = false;
            gbSize.Text = "Size";
            // 
            // gbCrustType
            // 
            gbCrustType.Controls.Add(rbThinkCrust);
            gbCrustType.Controls.Add(rbThinCrust);
            gbCrustType.Location = new Point(41, 309);
            gbCrustType.Name = "gbCrustType";
            gbCrustType.Size = new Size(176, 92);
            gbCrustType.TabIndex = 16;
            gbCrustType.TabStop = false;
            gbCrustType.Text = "Cryst Type";
            // 
            // gbWhereToEat
            // 
            gbWhereToEat.Controls.Add(rbTakeOut);
            gbWhereToEat.Controls.Add(rbEatIn);
            gbWhereToEat.Location = new Point(339, 309);
            gbWhereToEat.Name = "gbWhereToEat";
            gbWhereToEat.Size = new Size(296, 92);
            gbWhereToEat.TabIndex = 17;
            gbWhereToEat.TabStop = false;
            gbWhereToEat.Text = "Where To Eat";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 13.8F);
            label3.Location = new Point(742, 196);
            label3.Name = "label3";
            label3.Size = new Size(66, 29);
            label3.TabIndex = 19;
            label3.Text = "Size:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.8F);
            label5.Location = new Point(698, 233);
            label5.Name = "label5";
            label5.Size = new Size(110, 29);
            label5.TabIndex = 21;
            label5.Text = "Topping:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 13.8F);
            label7.Location = new Point(672, 270);
            label7.Name = "label7";
            label7.Size = new Size(136, 29);
            label7.TabIndex = 23;
            label7.Text = "Crust Type:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft Sans Serif", 13.8F);
            label9.Location = new Point(641, 307);
            label9.Name = "label9";
            label9.Size = new Size(167, 29);
            label9.TabIndex = 25;
            label9.Text = "Where To Eat:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.Red;
            label11.Location = new Point(666, 385);
            label11.Name = "label11";
            label11.Size = new Size(173, 41);
            label11.TabIndex = 27;
            label11.Text = "Total Price:";
            // 
            // lbTotalPrice
            // 
            lbTotalPrice.AutoSize = true;
            lbTotalPrice.Font = new Font("Segoe UI", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbTotalPrice.ForeColor = Color.Red;
            lbTotalPrice.Location = new Point(845, 350);
            lbTotalPrice.Name = "lbTotalPrice";
            lbTotalPrice.Size = new Size(159, 106);
            lbTotalPrice.TabIndex = 28;
            lbTotalPrice.Text = " $0";
            lbTotalPrice.TextAlign = ContentAlignment.TopCenter;
            // 
            // btOrderPizza
            // 
            btOrderPizza.Location = new Point(339, 407);
            btOrderPizza.Name = "btOrderPizza";
            btOrderPizza.Size = new Size(148, 54);
            btOrderPizza.TabIndex = 29;
            btOrderPizza.Text = "Order Pizza";
            btOrderPizza.UseVisualStyleBackColor = true;
            btOrderPizza.Click += btOrderPizza_Click_1;
            // 
            // btReset
            // 
            btReset.Location = new Point(487, 407);
            btReset.Name = "btReset";
            btReset.Size = new Size(148, 54);
            btReset.TabIndex = 30;
            btReset.Text = "Reset";
            btReset.UseVisualStyleBackColor = true;
            btReset.Click += btReset_Click;
            // 
            // lbSize
            // 
            lbSize.AutoSize = true;
            lbSize.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lbSize.ForeColor = Color.Black;
            lbSize.Location = new Point(822, 200);
            lbSize.Name = "lbSize";
            lbSize.Size = new Size(103, 20);
            lbSize.TabIndex = 31;
            lbSize.Text = "fgrtyuiytgfd";
            // 
            // lbToppings
            // 
            lbToppings.AutoSize = true;
            lbToppings.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lbToppings.Location = new Point(822, 237);
            lbToppings.Name = "lbToppings";
            lbToppings.Size = new Size(136, 20);
            lbToppings.TabIndex = 32;
            lbToppings.Text = "zrtyuiouyjhgfds";
            // 
            // lbCrusType
            // 
            lbCrusType.AutoSize = true;
            lbCrusType.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lbCrusType.Location = new Point(822, 274);
            lbCrusType.Name = "lbCrusType";
            lbCrusType.Size = new Size(99, 20);
            lbCrusType.TabIndex = 33;
            lbCrusType.Text = "lkjhgflkjhgf";
            // 
            // lbWhereToEat
            // 
            lbWhereToEat.AutoSize = true;
            lbWhereToEat.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold);
            lbWhereToEat.Location = new Point(822, 311);
            lbWhereToEat.Name = "lbWhereToEat";
            lbWhereToEat.Size = new Size(170, 20);
            lbWhereToEat.TabIndex = 34;
            lbWhereToEat.Text = "ytuidgfhj               ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 474);
            Controls.Add(lbWhereToEat);
            Controls.Add(lbCrusType);
            Controls.Add(lbToppings);
            Controls.Add(lbSize);
            Controls.Add(btReset);
            Controls.Add(btOrderPizza);
            Controls.Add(lbTotalPrice);
            Controls.Add(label11);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(gbWhereToEat);
            Controls.Add(gbCrustType);
            Controls.Add(gbSize);
            Controls.Add(gbTopping);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load_1;
            gbTopping.ResumeLayout(false);
            gbTopping.PerformLayout();
            gbSize.ResumeLayout(false);
            gbSize.PerformLayout();
            gbCrustType.ResumeLayout(false);
            gbCrustType.PerformLayout();
            gbWhereToEat.ResumeLayout(false);
            gbWhereToEat.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private RadioButton rbSmall;
        private RadioButton rbMoyen;
        private RadioButton rbLarge;
        private RadioButton rbThinCrust;
        private RadioButton rbThinkCrust;
        private RadioButton rbEatIn;
        private RadioButton rbTakeOut;
        private CheckBox chkExtraSheese;
        private CheckBox chkMushrooms;
        private CheckBox chkTomatoes;
        private CheckBox chkOnion;
        private CheckBox chkOlive;
        private CheckBox chkGreenPaper;
        private GroupBox gbTopping;
        private GroupBox gbSize;
        private GroupBox gbCrustType;
        private GroupBox gbWhereToEat;
        private Label label3;
        private Label label5;
        private Label label7;
        private Label label9;
        private Label label11;
        private Label lbTotalPrice;
        private Button btOrderPizza;
        private Button btReset;
        private Label lbSize;
        private Label lbToppings;
        private Label lbCrusType;
        private Label lbWhereToEat;
    }
}
