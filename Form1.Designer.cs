namespace anotaLinks
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.linkTextBox = new System.Windows.Forms.TextBox();
            this.linksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSetAnotaLink = new anotaLinks.DataSetAnotaLink();
            this.descricao_do_linkTextBox = new System.Windows.Forms.TextBox();
            this.linksDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.linksTableAdapter = new anotaLinks.DataSetAnotaLinkTableAdapters.LinksTableAdapter();
            this.tableAdapterManager = new anotaLinks.DataSetAnotaLinkTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.linksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAnotaLink)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // linkTextBox
            // 
            this.linkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.linkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.linksBindingSource, "Link", true));
            this.linkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkTextBox.Location = new System.Drawing.Point(13, 53);
            this.linkTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.linkTextBox.Name = "linkTextBox";
            this.linkTextBox.Size = new System.Drawing.Size(320, 23);
            this.linkTextBox.TabIndex = 1;
            this.linkTextBox.TextChanged += new System.EventHandler(this.linkTextBox_TextChanged);
            // 
            // linksBindingSource
            // 
            this.linksBindingSource.DataMember = "Links";
            this.linksBindingSource.DataSource = this.dataSetAnotaLink;
            // 
            // dataSetAnotaLink
            // 
            this.dataSetAnotaLink.DataSetName = "DataSetAnotaLink";
            this.dataSetAnotaLink.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // descricao_do_linkTextBox
            // 
            this.descricao_do_linkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.descricao_do_linkTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.linksBindingSource, "Descricao_do_link", true));
            this.descricao_do_linkTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricao_do_linkTextBox.Location = new System.Drawing.Point(13, 127);
            this.descricao_do_linkTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.descricao_do_linkTextBox.Name = "descricao_do_linkTextBox";
            this.descricao_do_linkTextBox.Size = new System.Drawing.Size(320, 23);
            this.descricao_do_linkTextBox.TabIndex = 2;
            this.descricao_do_linkTextBox.TextChanged += new System.EventHandler(this.descricao_do_linkTextBox_TextChanged);
            // 
            // linksDataGridView
            // 
            this.linksDataGridView.AllowUserToAddRows = false;
            this.linksDataGridView.AllowUserToDeleteRows = false;
            this.linksDataGridView.AllowUserToOrderColumns = true;
            this.linksDataGridView.AutoGenerateColumns = false;
            this.linksDataGridView.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.linksDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.linksDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.linksDataGridView.DataSource = this.linksBindingSource;
            this.linksDataGridView.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.linksDataGridView.Location = new System.Drawing.Point(31, 224);
            this.linksDataGridView.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.linksDataGridView.Name = "linksDataGridView";
            this.linksDataGridView.ReadOnly = true;
            this.linksDataGridView.Size = new System.Drawing.Size(575, 202);
            this.linksDataGridView.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Link";
            this.dataGridViewTextBoxColumn2.HeaderText = "Link";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 250;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Descricao_do_link";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição do Link";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 293;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.AutoCompleteCustomSource.AddRange(new string[] {
            "abeirou",
            "abrunheiro",
            "agricultores",
            "aleijou",
            "aleviou",
            "amenizou",
            "anuições",
            "apicultores",
            "apliquemos",
            "aquecido",
            "arqueiro",
            "arquitecto",
            "audições",
            "aurélio",
            "autorize",
            "autêntico",
            "azulénio",
            "bagunceiro",
            "banqueiro",
            "barqueiro",
            "bifurcações",
            "bonequita",
            "cargueiro",
            "centralizou",
            "chuveirão",
            "cinquentão",
            "circulações",
            "comunicasse",
            "comunidade",
            "configurável",
            "congruência",
            "conquistasse",
            "consecutiva",
            "conseguia",
            "conseguida",
            "consensuais",
            "continuasse",
            "coqueiral",
            "corujeira",
            "costumeira",
            "costureira",
            "curandeiro",
            "divulgações",
            "denunciando",
            "descuidado",
            "desfigurado",
            "desilusão",
            "desnutrição",
            "destruição",
            "desunião",
            "ebulição",
            "educativo",
            "elucidado",
            "enguiçado",
            "entusiasmo",
            "enunciado",
            "equipado",
            "escultorica",
            "escuridão",
            "esqualidos",
            "estimulado",
            "estipulado",
            "estuário",
            "eucalipto",
            "euforia",
            "eufórica",
            "eufrosina",
            "evoluiram",
            "exaustivo",
            "fagueiro",
            "faqueiro",
            "feudalismo",
            "fogueira",
            "fragueiro",
            "frangueiro",
            "fumigações",
            "funerário",
            "gesticulando",
            "gouveia",
            "guardiões",
            "guarnecido",
            "guarnições",
            "guloseima",
            "hipotenusa",
            "ilustrações",
            "impetuosa",
            "impopulares",
            "impugnações",
            "imputações",
            "incestuosa",
            "inexpurgado",
            "insuportável",
            "irregulado",
            "irresoluta",
            "laurentino",
            "mangueiro",
            "manifestou",
            "maqueiro",
            "mastoideu",
            "metalúrgico",
            "meticulosa",
            "moçambique",
            "mucosidade",
            "mutilações",
            "neuronais",
            "neurótica",
            "nogueira",
            "numerário",
            "obscuridade",
            "opulência",
            "orquídea",
            "ousarei",
            "parquímetro",
            "patrulheiro",
            "pecuário",
            "perdulário",
            "persuasivo",
            "pesquisador",
            "pneumático",
            "porqueira",
            "preguiçosa",
            "prejudicado",
            "prenunciado",
            "profundidade",
            "progenitura",
            "pronunciasse",
            "publicações",
            "queimado",
            "questiona",
            "questionar",
            "reconstruía",
            "renunciado",
            "reproduzia",
            "republicano",
            "requintado",
            "reumatismo",
            "reunião",
            "rotundidade",
            "rugosidade",
            "salgueiro",
            "sanguíneos",
            "secundário",
            "seguidora",
            "sequiosa",
            "sequoia",
            "simuladores",
            "simultâneo",
            "situações",
            "soqueira",
            "sucateiro",
            "sujeitado",
            "superiora",
            "superlativo",
            "suportáveis",
            "surrealismo",
            "tabuleiro",
            "taquímetro",
            "toupeira",
            "tripulações",
            "ultimações",
            "vagueio",
            "vaqueiro",
            "vestuário",
            "vinculações",
            "wimbabueo",
            "zambujeiro"});
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(423, -44);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(297, 30);
            this.textBox1.TabIndex = 3;
            this.textBox1.Tag = "";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.AccessibleDescription = "";
            this.pictureBox1.AccessibleName = "";
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(363, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 33);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(451, 89);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(79, 33);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(538, 89);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(81, 33);
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DimGray;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 546);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "BY leonardo.wilbors@gmail.com";
            // 
            // linkLabel1
            // 
            this.linkLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(351, 136);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(268, 36);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Clique para abrir o Link";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // linksTableAdapter
            // 
            this.linksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.LinksTableAdapter = this.linksTableAdapter;
            this.tableAdapterManager.UpdateOrder = anotaLinks.DataSetAnotaLinkTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::anotaLinks.Properties.Resources.noteLinks;
            this.ClientSize = new System.Drawing.Size(631, 445);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.linksDataGridView);
            this.Controls.Add(this.linkTextBox);
            this.Controls.Add(this.descricao_do_linkTextBox);
            this.ForeColor = System.Drawing.Color.Blue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Anota Links";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.linksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetAnotaLink)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.linksDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataSetAnotaLink dataSetAnotaLink;
        private System.Windows.Forms.BindingSource linksBindingSource;
        private DataSetAnotaLinkTableAdapters.LinksTableAdapter linksTableAdapter;
        private DataSetAnotaLinkTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox linkTextBox;
        private System.Windows.Forms.TextBox descricao_do_linkTextBox;
        private System.Windows.Forms.DataGridView linksDataGridView;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Timer timer1;
    }
}

