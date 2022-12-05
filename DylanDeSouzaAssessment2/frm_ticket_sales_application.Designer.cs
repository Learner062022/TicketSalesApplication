namespace DylanDeSouzaAssessment2
{
    partial class frm_ticket_sales_application
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
            this.txt_number_adult_tickets = new System.Windows.Forms.TextBox();
            this.txt_number_child_tickets = new System.Windows.Forms.TextBox();
            this.txt_customer_change = new System.Windows.Forms.TextBox();
            this.txt_amount_from_customer = new System.Windows.Forms.TextBox();
            this.txt_ticket_cost = new System.Windows.Forms.TextBox();
            this.btn_calculate_ticket_cost = new System.Windows.Forms.Button();
            this.btn_calculate_change = new System.Windows.Forms.Button();
            this.lbl_number_adults = new System.Windows.Forms.Label();
            this.lbl_customer_change = new System.Windows.Forms.Label();
            this.lbl_ticket_cost = new System.Windows.Forms.Label();
            this.lbl_amount_from_customer = new System.Windows.Forms.Label();
            this.lbl_number_child_tickets = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_number_adult_tickets
            // 
            this.txt_number_adult_tickets.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_number_adult_tickets.Location = new System.Drawing.Point(309, 87);
            this.txt_number_adult_tickets.Name = "txt_number_adult_tickets";
            this.txt_number_adult_tickets.Size = new System.Drawing.Size(100, 20);
            this.txt_number_adult_tickets.TabIndex = 0;
            // 
            // txt_number_child_tickets
            // 
            this.txt_number_child_tickets.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_number_child_tickets.Location = new System.Drawing.Point(309, 113);
            this.txt_number_child_tickets.Name = "txt_number_child_tickets";
            this.txt_number_child_tickets.Size = new System.Drawing.Size(100, 20);
            this.txt_number_child_tickets.TabIndex = 1;
            // 
            // txt_customer_change
            // 
            this.txt_customer_change.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_customer_change.Location = new System.Drawing.Point(309, 278);
            this.txt_customer_change.Name = "txt_customer_change";
            this.txt_customer_change.ReadOnly = true;
            this.txt_customer_change.Size = new System.Drawing.Size(100, 20);
            this.txt_customer_change.TabIndex = 2;
            this.txt_customer_change.TabStop = false;
            // 
            // txt_amount_from_customer
            // 
            this.txt_amount_from_customer.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_amount_from_customer.Location = new System.Drawing.Point(309, 220);
            this.txt_amount_from_customer.Name = "txt_amount_from_customer";
            this.txt_amount_from_customer.Size = new System.Drawing.Size(100, 20);
            this.txt_amount_from_customer.TabIndex = 3;
            // 
            // txt_ticket_cost
            // 
            this.txt_ticket_cost.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txt_ticket_cost.Location = new System.Drawing.Point(309, 168);
            this.txt_ticket_cost.Name = "txt_ticket_cost";
            this.txt_ticket_cost.ReadOnly = true;
            this.txt_ticket_cost.Size = new System.Drawing.Size(100, 20);
            this.txt_ticket_cost.TabIndex = 4;
            this.txt_ticket_cost.TabStop = false;
            // 
            // btn_calculate_ticket_cost
            // 
            this.btn_calculate_ticket_cost.Location = new System.Drawing.Point(290, 139);
            this.btn_calculate_ticket_cost.Name = "btn_calculate_ticket_cost";
            this.btn_calculate_ticket_cost.Size = new System.Drawing.Size(119, 23);
            this.btn_calculate_ticket_cost.TabIndex = 5;
            this.btn_calculate_ticket_cost.Text = "Calculate Ticket Cost";
            this.btn_calculate_ticket_cost.UseVisualStyleBackColor = true;
            this.btn_calculate_ticket_cost.Click += new System.EventHandler(this.btn_calculate_ticket_cost_Click);
            // 
            // btn_calculate_change
            // 
            this.btn_calculate_change.Location = new System.Drawing.Point(305, 246);
            this.btn_calculate_change.Name = "btn_calculate_change";
            this.btn_calculate_change.Size = new System.Drawing.Size(104, 23);
            this.btn_calculate_change.TabIndex = 6;
            this.btn_calculate_change.Text = "Calculate Change";
            this.btn_calculate_change.UseVisualStyleBackColor = true;
            this.btn_calculate_change.Click += new System.EventHandler(this.btn_calculate_change_Click);
            // 
            // lbl_number_adults
            // 
            this.lbl_number_adults.AutoSize = true;
            this.lbl_number_adults.Location = new System.Drawing.Point(182, 94);
            this.lbl_number_adults.Name = "lbl_number_adults";
            this.lbl_number_adults.Size = new System.Drawing.Size(121, 13);
            this.lbl_number_adults.TabIndex = 7;
            this.lbl_number_adults.Text = "Number of Adult Tickets";
            // 
            // lbl_customer_change
            // 
            this.lbl_customer_change.AutoSize = true;
            this.lbl_customer_change.Location = new System.Drawing.Point(212, 285);
            this.lbl_customer_change.Name = "lbl_customer_change";
            this.lbl_customer_change.Size = new System.Drawing.Size(91, 13);
            this.lbl_customer_change.TabIndex = 8;
            this.lbl_customer_change.Text = "Customer Change";
            // 
            // lbl_ticket_cost
            // 
            this.lbl_ticket_cost.AutoSize = true;
            this.lbl_ticket_cost.Location = new System.Drawing.Point(242, 175);
            this.lbl_ticket_cost.Name = "lbl_ticket_cost";
            this.lbl_ticket_cost.Size = new System.Drawing.Size(61, 13);
            this.lbl_ticket_cost.TabIndex = 9;
            this.lbl_ticket_cost.Text = "Ticket Cost";
            // 
            // lbl_amount_from_customer
            // 
            this.lbl_amount_from_customer.AutoSize = true;
            this.lbl_amount_from_customer.Location = new System.Drawing.Point(190, 227);
            this.lbl_amount_from_customer.Name = "lbl_amount_from_customer";
            this.lbl_amount_from_customer.Size = new System.Drawing.Size(113, 13);
            this.lbl_amount_from_customer.TabIndex = 10;
            this.lbl_amount_from_customer.Text = "Amount from Customer";
            // 
            // lbl_number_child_tickets
            // 
            this.lbl_number_child_tickets.AutoSize = true;
            this.lbl_number_child_tickets.Location = new System.Drawing.Point(183, 120);
            this.lbl_number_child_tickets.Name = "lbl_number_child_tickets";
            this.lbl_number_child_tickets.Size = new System.Drawing.Size(120, 13);
            this.lbl_number_child_tickets.TabIndex = 12;
            this.lbl_number_child_tickets.Text = "Number of Child Tickets";
            // 
            // frm_ticket_sales_application
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_number_child_tickets);
            this.Controls.Add(this.lbl_amount_from_customer);
            this.Controls.Add(this.lbl_ticket_cost);
            this.Controls.Add(this.lbl_customer_change);
            this.Controls.Add(this.lbl_number_adults);
            this.Controls.Add(this.btn_calculate_change);
            this.Controls.Add(this.btn_calculate_ticket_cost);
            this.Controls.Add(this.txt_ticket_cost);
            this.Controls.Add(this.txt_amount_from_customer);
            this.Controls.Add(this.txt_customer_change);
            this.Controls.Add(this.txt_number_child_tickets);
            this.Controls.Add(this.txt_number_adult_tickets);
            this.Name = "frm_ticket_sales_application";
            this.Text = "Ticket Sales Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_number_adult_tickets;
        private System.Windows.Forms.TextBox txt_number_child_tickets;
        private System.Windows.Forms.TextBox txt_customer_change;
        private System.Windows.Forms.TextBox txt_amount_from_customer;
        private System.Windows.Forms.TextBox txt_ticket_cost;
        private System.Windows.Forms.Button btn_calculate_ticket_cost;
        private System.Windows.Forms.Button btn_calculate_change;
        private System.Windows.Forms.Label lbl_number_adults;
        private System.Windows.Forms.Label lbl_customer_change;
        private System.Windows.Forms.Label lbl_ticket_cost;
        private System.Windows.Forms.Label lbl_amount_from_customer;
        private System.Windows.Forms.Label lbl_number_child_tickets;
    }
}

