namespace CHU_Rennes_DRH
{
    partial class fmr_crd
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lbl_selectuser = new System.Windows.Forms.Label();
            this.cbx_selectFormation = new System.Windows.Forms.ComboBox();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet2 = new CHU_Rennes_DRH.DatabaseDataSet();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_titleFormation = new System.Windows.Forms.Label();
            this.lbl_formationName = new System.Windows.Forms.Label();
            this.lbl_formationDesc = new System.Windows.Forms.Label();
            this.lkl_formationLink = new System.Windows.Forms.LinkLabel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_createUser = new System.Windows.Forms.Label();
            this.tbx_createUser = new System.Windows.Forms.TextBox();
            this.lbl_createUserFormation = new System.Windows.Forms.Label();
            this.cbx_createUserFormation = new System.Windows.Forms.ComboBox();
            this.formationsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.databaseDataSet1 = new CHU_Rennes_DRH.DatabaseDataSet();
            this.btn_createUser = new System.Windows.Forms.Button();
            this.databaseDataSet = new CHU_Rennes_DRH.DatabaseDataSet();
            this.databaseDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.formationsTableAdapter = new CHU_Rennes_DRH.DatabaseDataSetTableAdapters.FormationsTableAdapter();
            this.usersTableAdapter = new CHU_Rennes_DRH.DatabaseDataSetTableAdapters.UsersTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formationsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_selectuser
            // 
            this.lbl_selectuser.AutoSize = true;
            this.lbl_selectuser.Location = new System.Drawing.Point(26, 19);
            this.lbl_selectuser.Name = "lbl_selectuser";
            this.lbl_selectuser.Size = new System.Drawing.Size(137, 13);
            this.lbl_selectuser.TabIndex = 0;
            this.lbl_selectuser.Text = "Sélectionner un utilisateur : ";
            this.lbl_selectuser.Click += new System.EventHandler(this.lbl_selectuser_Click);
            // 
            // cbx_selectFormation
            // 
            this.cbx_selectFormation.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.usersBindingSource, "user", true));
            this.cbx_selectFormation.DataSource = this.usersBindingSource;
            this.cbx_selectFormation.DisplayMember = "user";
            this.cbx_selectFormation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_selectFormation.FormattingEnabled = true;
            this.cbx_selectFormation.Location = new System.Drawing.Point(169, 16);
            this.cbx_selectFormation.Name = "cbx_selectFormation";
            this.cbx_selectFormation.Size = new System.Drawing.Size(297, 21);
            this.cbx_selectFormation.TabIndex = 1;
            this.cbx_selectFormation.ValueMember = "user";
            this.cbx_selectFormation.SelectedIndexChanged += new System.EventHandler(this.cbx_selectFormation_SelectedIndexChanged);
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.databaseDataSet2;
            // 
            // databaseDataSet2
            // 
            this.databaseDataSet2.DataSetName = "DatabaseDataSet";
            this.databaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_formationName, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.lbl_formationDesc, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.lkl_formationLink, 0, 3);
            this.tableLayoutPanel4.Controls.Add(this.lbl_titleFormation, 0, 0);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(29, 43);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 4;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.29252F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.97959F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(437, 159);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // lbl_titleFormation
            // 
            this.lbl_titleFormation.AutoSize = true;
            this.lbl_titleFormation.Location = new System.Drawing.Point(3, 0);
            this.lbl_titleFormation.Name = "lbl_titleFormation";
            this.lbl_titleFormation.Size = new System.Drawing.Size(119, 13);
            this.lbl_titleFormation.TabIndex = 0;
            this.lbl_titleFormation.Text = "Formation de l\'utilisateur";
            // 
            // lbl_formationName
            // 
            this.lbl_formationName.AutoSize = true;
            this.lbl_formationName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_formationName.Location = new System.Drawing.Point(3, 22);
            this.lbl_formationName.Name = "lbl_formationName";
            this.lbl_formationName.Size = new System.Drawing.Size(0, 13);
            this.lbl_formationName.TabIndex = 1;
            // 
            // lbl_formationDesc
            // 
            this.lbl_formationDesc.AutoSize = true;
            this.lbl_formationDesc.Location = new System.Drawing.Point(3, 57);
            this.lbl_formationDesc.Name = "lbl_formationDesc";
            this.lbl_formationDesc.Size = new System.Drawing.Size(0, 13);
            this.lbl_formationDesc.TabIndex = 2;
            // 
            // lkl_formationLink
            // 
            this.lkl_formationLink.AutoSize = true;
            this.lkl_formationLink.Location = new System.Drawing.Point(3, 112);
            this.lkl_formationLink.Name = "lkl_formationLink";
            this.lkl_formationLink.Size = new System.Drawing.Size(0, 13);
            this.lkl_formationLink.TabIndex = 3;
            this.lkl_formationLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkl_formationLink_LinkClicked);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tbx_createUser, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.lbl_createUserFormation, 0, 2);
            this.tableLayoutPanel5.Controls.Add(this.btn_createUser, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.cbx_createUserFormation, 0, 3);
            this.tableLayoutPanel5.Controls.Add(this.lbl_createUser, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(472, 19);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 5;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.33588F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.03053F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.57143F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(267, 183);
            this.tableLayoutPanel5.TabIndex = 1;
            // 
            // lbl_createUser
            // 
            this.lbl_createUser.AutoSize = true;
            this.lbl_createUser.Location = new System.Drawing.Point(3, 0);
            this.lbl_createUser.Name = "lbl_createUser";
            this.lbl_createUser.Size = new System.Drawing.Size(94, 13);
            this.lbl_createUser.TabIndex = 0;
            this.lbl_createUser.Text = "Créer un utilisateur";
            // 
            // tbx_createUser
            // 
            this.tbx_createUser.Location = new System.Drawing.Point(3, 29);
            this.tbx_createUser.Name = "tbx_createUser";
            this.tbx_createUser.Size = new System.Drawing.Size(258, 20);
            this.tbx_createUser.TabIndex = 1;
            // 
            // lbl_createUserFormation
            // 
            this.lbl_createUserFormation.AutoSize = true;
            this.lbl_createUserFormation.Location = new System.Drawing.Point(3, 74);
            this.lbl_createUserFormation.Name = "lbl_createUserFormation";
            this.lbl_createUserFormation.Size = new System.Drawing.Size(133, 13);
            this.lbl_createUserFormation.TabIndex = 2;
            this.lbl_createUserFormation.Text = "Sélectionner une formation";
            // 
            // cbx_createUserFormation
            // 
            this.cbx_createUserFormation.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.formationsBindingSource, "nom", true));
            this.cbx_createUserFormation.DataSource = this.formationsBindingSource;
            this.cbx_createUserFormation.DisplayMember = "nom";
            this.cbx_createUserFormation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbx_createUserFormation.FormattingEnabled = true;
            this.cbx_createUserFormation.Location = new System.Drawing.Point(3, 106);
            this.cbx_createUserFormation.Name = "cbx_createUserFormation";
            this.cbx_createUserFormation.Size = new System.Drawing.Size(258, 21);
            this.cbx_createUserFormation.TabIndex = 3;
            this.cbx_createUserFormation.ValueMember = "nom";
            // 
            // formationsBindingSource
            // 
            this.formationsBindingSource.DataMember = "Formations";
            this.formationsBindingSource.DataSource = this.databaseDataSet1;
            // 
            // databaseDataSet1
            // 
            this.databaseDataSet1.DataSetName = "DatabaseDataSet";
            this.databaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_createUser
            // 
            this.btn_createUser.Location = new System.Drawing.Point(3, 158);
            this.btn_createUser.Name = "btn_createUser";
            this.btn_createUser.Size = new System.Drawing.Size(258, 22);
            this.btn_createUser.TabIndex = 4;
            this.btn_createUser.Text = "Créer un utilisateur";
            this.btn_createUser.UseVisualStyleBackColor = true;
            this.btn_createUser.Click += new System.EventHandler(this.btn_createUser_Click);
            // 
            // databaseDataSet
            // 
            this.databaseDataSet.DataSetName = "DatabaseDataSet";
            this.databaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // databaseDataSetBindingSource
            // 
            this.databaseDataSetBindingSource.DataSource = this.databaseDataSet;
            this.databaseDataSetBindingSource.Position = 0;
            // 
            // formationsTableAdapter
            // 
            this.formationsTableAdapter.ClearBeforeFill = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // fmr_crd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 218);
            this.Controls.Add(this.cbx_selectFormation);
            this.Controls.Add(this.lbl_selectuser);
            this.Controls.Add(this.tableLayoutPanel5);
            this.Controls.Add(this.tableLayoutPanel4);
            this.Name = "fmr_crd";
            this.Text = "CHU";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet2)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.formationsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.databaseDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_selectuser;
        private System.Windows.Forms.ComboBox cbx_selectFormation;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_titleFormation;
        private System.Windows.Forms.Label lbl_formationName;
        private System.Windows.Forms.Label lbl_formationDesc;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label lbl_createUser;
        private System.Windows.Forms.TextBox tbx_createUser;
        private System.Windows.Forms.Label lbl_createUserFormation;
        private System.Windows.Forms.ComboBox cbx_createUserFormation;
        private System.Windows.Forms.Button btn_createUser;
        private DatabaseDataSet databaseDataSet;
        private System.Windows.Forms.BindingSource databaseDataSetBindingSource;
        private DatabaseDataSet databaseDataSet1;
        private System.Windows.Forms.BindingSource formationsBindingSource;
        private DatabaseDataSetTableAdapters.FormationsTableAdapter formationsTableAdapter;
        private DatabaseDataSet databaseDataSet2;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private DatabaseDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.LinkLabel lkl_formationLink;
    }
}

