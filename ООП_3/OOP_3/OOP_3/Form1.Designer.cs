namespace OOP_3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBoxMain = new System.Windows.Forms.ComboBox();
            this.textBoxProductName = new System.Windows.Forms.TextBox();
            this.textBoxCal = new System.Windows.Forms.TextBox();
            this.textBoxShelfLife = new System.Windows.Forms.TextBox();
            this.textBoxDataManufacture = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AnimalProducts = new System.Windows.Forms.Panel();
            this.comboBoxReadyToEat = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxAnimal = new System.Windows.Forms.TextBox();
            this.panelMilck = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxLactose = new System.Windows.Forms.ComboBox();
            this.textBoxFatness = new System.Windows.Forms.TextBox();
            this.textBoxTypeMilck = new System.Windows.Forms.TextBox();
            this.panelMeat = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxFreez = new System.Windows.Forms.ComboBox();
            this.textBoxMeatType = new System.Windows.Forms.TextBox();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.buttonAdd = new System.Windows.Forms.Button();
            this.panelDrinks = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxTypeDrink = new System.Windows.Forms.TextBox();
            this.comboBoxAlcohol = new System.Windows.Forms.ComboBox();
            this.comboBoxGaz = new System.Windows.Forms.ComboBox();
            this.comboBoxdrinkRady = new System.Windows.Forms.ComboBox();
            this.panelVegetableProducts = new System.Windows.Forms.Panel();
            this.panelFlour = new System.Windows.Forms.Panel();
            this.comboBoxSugar = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.textBoxSortFlour = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.textBoxTypeFlour = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxGMO = new System.Windows.Forms.ComboBox();
            this.textBoxVitamins = new System.Windows.Forms.TextBox();
            this.panelCereal = new System.Windows.Forms.Panel();
            this.textBoxSortCereal = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.textBoxTypeCereal = new System.Windows.Forms.TextBox();
            this.AnimalProducts.SuspendLayout();
            this.panelMilck.SuspendLayout();
            this.panelMeat.SuspendLayout();
            this.panelDrinks.SuspendLayout();
            this.panelVegetableProducts.SuspendLayout();
            this.panelFlour.SuspendLayout();
            this.panelCereal.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxMain
            // 
            this.comboBoxMain.FormattingEnabled = true;
            this.comboBoxMain.Items.AddRange(new object[] {
            "Молочная продукция",
            "Мясные изделия",
            "Бакалея",
            "Мучные продукты ",
            "Напитки"});
            this.comboBoxMain.Location = new System.Drawing.Point(27, 21);
            this.comboBoxMain.Name = "comboBoxMain";
            this.comboBoxMain.Size = new System.Drawing.Size(179, 21);
            this.comboBoxMain.TabIndex = 0;
            this.comboBoxMain.SelectedIndexChanged += new System.EventHandler(this.comboBoxMain_Click);
            // 
            // textBoxProductName
            // 
            this.textBoxProductName.Location = new System.Drawing.Point(27, 88);
            this.textBoxProductName.Name = "textBoxProductName";
            this.textBoxProductName.Size = new System.Drawing.Size(179, 22);
            this.textBoxProductName.TabIndex = 1;
            // 
            // textBoxCal
            // 
            this.textBoxCal.Location = new System.Drawing.Point(27, 146);
            this.textBoxCal.Name = "textBoxCal";
            this.textBoxCal.Size = new System.Drawing.Size(179, 22);
            this.textBoxCal.TabIndex = 2;
            // 
            // textBoxShelfLife
            // 
            this.textBoxShelfLife.Location = new System.Drawing.Point(27, 206);
            this.textBoxShelfLife.Name = "textBoxShelfLife";
            this.textBoxShelfLife.Size = new System.Drawing.Size(179, 22);
            this.textBoxShelfLife.TabIndex = 3;
            // 
            // textBoxDataManufacture
            // 
            this.textBoxDataManufacture.Location = new System.Drawing.Point(27, 267);
            this.textBoxDataManufacture.Name = "textBoxDataManufacture";
            this.textBoxDataManufacture.Size = new System.Drawing.Size(179, 22);
            this.textBoxDataManufacture.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Название продукта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Калорийность:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(130, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Срок годностей (дней):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Дата изготовления:";
            // 
            // AnimalProducts
            // 
            this.AnimalProducts.Controls.Add(this.comboBoxReadyToEat);
            this.AnimalProducts.Controls.Add(this.label6);
            this.AnimalProducts.Controls.Add(this.label5);
            this.AnimalProducts.Controls.Add(this.textBoxAnimal);
            this.AnimalProducts.Controls.Add(this.panelMilck);
            this.AnimalProducts.Controls.Add(this.panelMeat);
            this.AnimalProducts.Location = new System.Drawing.Point(231, 12);
            this.AnimalProducts.Name = "AnimalProducts";
            this.AnimalProducts.Size = new System.Drawing.Size(232, 277);
            this.AnimalProducts.TabIndex = 9;
            // 
            // comboBoxReadyToEat
            // 
            this.comboBoxReadyToEat.FormattingEnabled = true;
            this.comboBoxReadyToEat.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBoxReadyToEat.Location = new System.Drawing.Point(3, 66);
            this.comboBoxReadyToEat.Name = "comboBoxReadyToEat";
            this.comboBoxReadyToEat.Size = new System.Drawing.Size(214, 21);
            this.comboBoxReadyToEat.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Готовность к использованию:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Из какого животоного произведено:";
            // 
            // textBoxAnimal
            // 
            this.textBoxAnimal.Location = new System.Drawing.Point(3, 25);
            this.textBoxAnimal.Name = "textBoxAnimal";
            this.textBoxAnimal.Size = new System.Drawing.Size(214, 22);
            this.textBoxAnimal.TabIndex = 0;
            // 
            // panelMilck
            // 
            this.panelMilck.Controls.Add(this.label9);
            this.panelMilck.Controls.Add(this.label8);
            this.panelMilck.Controls.Add(this.label7);
            this.panelMilck.Controls.Add(this.comboBoxLactose);
            this.panelMilck.Controls.Add(this.textBoxFatness);
            this.panelMilck.Controls.Add(this.textBoxTypeMilck);
            this.panelMilck.Location = new System.Drawing.Point(1, 93);
            this.panelMilck.Name = "panelMilck";
            this.panelMilck.Size = new System.Drawing.Size(221, 159);
            this.panelMilck.TabIndex = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(3, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Содержание лактозы:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Жирность:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Тип молчного  продукта:";
            // 
            // comboBoxLactose
            // 
            this.comboBoxLactose.FormattingEnabled = true;
            this.comboBoxLactose.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBoxLactose.Location = new System.Drawing.Point(4, 121);
            this.comboBoxLactose.Name = "comboBoxLactose";
            this.comboBoxLactose.Size = new System.Drawing.Size(214, 21);
            this.comboBoxLactose.TabIndex = 5;
            // 
            // textBoxFatness
            // 
            this.textBoxFatness.Location = new System.Drawing.Point(4, 78);
            this.textBoxFatness.Name = "textBoxFatness";
            this.textBoxFatness.Size = new System.Drawing.Size(214, 22);
            this.textBoxFatness.TabIndex = 12;
            // 
            // textBoxTypeMilck
            // 
            this.textBoxTypeMilck.Location = new System.Drawing.Point(4, 27);
            this.textBoxTypeMilck.Name = "textBoxTypeMilck";
            this.textBoxTypeMilck.Size = new System.Drawing.Size(214, 22);
            this.textBoxTypeMilck.TabIndex = 11;
            // 
            // panelMeat
            // 
            this.panelMeat.Controls.Add(this.label10);
            this.panelMeat.Controls.Add(this.label12);
            this.panelMeat.Controls.Add(this.comboBoxFreez);
            this.panelMeat.Controls.Add(this.textBoxMeatType);
            this.panelMeat.Location = new System.Drawing.Point(-1, 93);
            this.panelMeat.Name = "panelMeat";
            this.panelMeat.Size = new System.Drawing.Size(221, 159);
            this.panelMeat.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(5, 65);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Замороженное или нет:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 11);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(129, 13);
            this.label12.TabIndex = 11;
            this.label12.Text = "Тип мясного продукта:";
            // 
            // comboBoxFreez
            // 
            this.comboBoxFreez.FormattingEnabled = true;
            this.comboBoxFreez.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBoxFreez.Location = new System.Drawing.Point(4, 90);
            this.comboBoxFreez.Name = "comboBoxFreez";
            this.comboBoxFreez.Size = new System.Drawing.Size(214, 21);
            this.comboBoxFreez.TabIndex = 5;
            // 
            // textBoxMeatType
            // 
            this.textBoxMeatType.Location = new System.Drawing.Point(4, 27);
            this.textBoxMeatType.Name = "textBoxMeatType";
            this.textBoxMeatType.Size = new System.Drawing.Size(214, 22);
            this.textBoxMeatType.TabIndex = 11;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(27, 315);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(75, 23);
            this.buttonAdd.TabIndex = 16;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // panelDrinks
            // 
            this.panelDrinks.Controls.Add(this.label15);
            this.panelDrinks.Controls.Add(this.label14);
            this.panelDrinks.Controls.Add(this.label13);
            this.panelDrinks.Controls.Add(this.label11);
            this.panelDrinks.Controls.Add(this.textBoxTypeDrink);
            this.panelDrinks.Controls.Add(this.comboBoxAlcohol);
            this.panelDrinks.Controls.Add(this.comboBoxGaz);
            this.panelDrinks.Controls.Add(this.comboBoxdrinkRady);
            this.panelDrinks.Location = new System.Drawing.Point(230, 12);
            this.panelDrinks.Name = "panelDrinks";
            this.panelDrinks.Size = new System.Drawing.Size(233, 277);
            this.panelDrinks.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(4, 173);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(116, 13);
            this.label15.TabIndex = 22;
            this.label15.Text = "Содержит алкоголь:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(4, 119);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(128, 13);
            this.label14.TabIndex = 21;
            this.label14.Text = "Готов к употреблению";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 60);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(88, 13);
            this.label13.TabIndex = 20;
            this.label13.Text = "Газированный:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(4, 10);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 13);
            this.label11.TabIndex = 19;
            this.label11.Text = "Тип напитка:";
            // 
            // textBoxTypeDrink
            // 
            this.textBoxTypeDrink.Location = new System.Drawing.Point(4, 29);
            this.textBoxTypeDrink.Name = "textBoxTypeDrink";
            this.textBoxTypeDrink.Size = new System.Drawing.Size(214, 22);
            this.textBoxTypeDrink.TabIndex = 18;
            // 
            // comboBoxAlcohol
            // 
            this.comboBoxAlcohol.FormattingEnabled = true;
            this.comboBoxAlcohol.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBoxAlcohol.Location = new System.Drawing.Point(4, 189);
            this.comboBoxAlcohol.Name = "comboBoxAlcohol";
            this.comboBoxAlcohol.Size = new System.Drawing.Size(214, 21);
            this.comboBoxAlcohol.TabIndex = 7;
            // 
            // comboBoxGaz
            // 
            this.comboBoxGaz.FormattingEnabled = true;
            this.comboBoxGaz.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBoxGaz.Location = new System.Drawing.Point(4, 78);
            this.comboBoxGaz.Name = "comboBoxGaz";
            this.comboBoxGaz.Size = new System.Drawing.Size(214, 21);
            this.comboBoxGaz.TabIndex = 6;
            // 
            // comboBoxdrinkRady
            // 
            this.comboBoxdrinkRady.FormattingEnabled = true;
            this.comboBoxdrinkRady.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBoxdrinkRady.Location = new System.Drawing.Point(4, 135);
            this.comboBoxdrinkRady.Name = "comboBoxdrinkRady";
            this.comboBoxdrinkRady.Size = new System.Drawing.Size(214, 21);
            this.comboBoxdrinkRady.TabIndex = 5;
            // 
            // panelVegetableProducts
            // 
            this.panelVegetableProducts.Controls.Add(this.panelFlour);
            this.panelVegetableProducts.Controls.Add(this.label17);
            this.panelVegetableProducts.Controls.Add(this.label16);
            this.panelVegetableProducts.Controls.Add(this.comboBoxGMO);
            this.panelVegetableProducts.Controls.Add(this.textBoxVitamins);
            this.panelVegetableProducts.Controls.Add(this.panelCereal);
            this.panelVegetableProducts.Location = new System.Drawing.Point(233, 8);
            this.panelVegetableProducts.Name = "panelVegetableProducts";
            this.panelVegetableProducts.Size = new System.Drawing.Size(233, 277);
            this.panelVegetableProducts.TabIndex = 18;
            // 
            // panelFlour
            // 
            this.panelFlour.Controls.Add(this.comboBoxSugar);
            this.panelFlour.Controls.Add(this.label22);
            this.panelFlour.Controls.Add(this.textBoxSortFlour);
            this.panelFlour.Controls.Add(this.label20);
            this.panelFlour.Controls.Add(this.label21);
            this.panelFlour.Controls.Add(this.textBoxTypeFlour);
            this.panelFlour.Location = new System.Drawing.Point(0, 105);
            this.panelFlour.Name = "panelFlour";
            this.panelFlour.Size = new System.Drawing.Size(233, 169);
            this.panelFlour.TabIndex = 26;
            // 
            // comboBoxSugar
            // 
            this.comboBoxSugar.FormattingEnabled = true;
            this.comboBoxSugar.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBoxSugar.Location = new System.Drawing.Point(3, 133);
            this.comboBoxSugar.Name = "comboBoxSugar";
            this.comboBoxSugar.Size = new System.Drawing.Size(214, 21);
            this.comboBoxSugar.TabIndex = 25;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(5, 108);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(116, 13);
            this.label22.TabIndex = 26;
            this.label22.Text = "Содержание сахара:";
            // 
            // textBoxSortFlour
            // 
            this.textBoxSortFlour.Location = new System.Drawing.Point(3, 82);
            this.textBoxSortFlour.Name = "textBoxSortFlour";
            this.textBoxSortFlour.Size = new System.Drawing.Size(214, 22);
            this.textBoxSortFlour.TabIndex = 25;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(5, 61);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(65, 13);
            this.label20.TabIndex = 24;
            this.label20.Text = "Сорт муки:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(3, 10);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(130, 13);
            this.label21.TabIndex = 23;
            this.label21.Text = "Тип мучного продукта:";
            // 
            // textBoxTypeFlour
            // 
            this.textBoxTypeFlour.Location = new System.Drawing.Point(3, 25);
            this.textBoxTypeFlour.Name = "textBoxTypeFlour";
            this.textBoxTypeFlour.Size = new System.Drawing.Size(214, 22);
            this.textBoxTypeFlour.TabIndex = 23;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 13);
            this.label17.TabIndex = 24;
            this.label17.Text = "Содержание ГМО:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 10);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(148, 13);
            this.label16.TabIndex = 23;
            this.label16.Text = "Cодержащиеся витамины:";
            // 
            // comboBoxGMO
            // 
            this.comboBoxGMO.FormattingEnabled = true;
            this.comboBoxGMO.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBoxGMO.Location = new System.Drawing.Point(3, 69);
            this.comboBoxGMO.Name = "comboBoxGMO";
            this.comboBoxGMO.Size = new System.Drawing.Size(214, 21);
            this.comboBoxGMO.TabIndex = 23;
            // 
            // textBoxVitamins
            // 
            this.textBoxVitamins.Location = new System.Drawing.Point(3, 25);
            this.textBoxVitamins.Name = "textBoxVitamins";
            this.textBoxVitamins.Size = new System.Drawing.Size(214, 22);
            this.textBoxVitamins.TabIndex = 23;
            // 
            // panelCereal
            // 
            this.panelCereal.Controls.Add(this.textBoxSortCereal);
            this.panelCereal.Controls.Add(this.label18);
            this.panelCereal.Controls.Add(this.label19);
            this.panelCereal.Controls.Add(this.textBoxTypeCereal);
            this.panelCereal.Location = new System.Drawing.Point(0, 95);
            this.panelCereal.Name = "panelCereal";
            this.panelCereal.Size = new System.Drawing.Size(233, 137);
            this.panelCereal.TabIndex = 25;
            // 
            // textBoxSortCereal
            // 
            this.textBoxSortCereal.Location = new System.Drawing.Point(4, 80);
            this.textBoxSortCereal.Name = "textBoxSortCereal";
            this.textBoxSortCereal.Size = new System.Drawing.Size(214, 22);
            this.textBoxSortCereal.TabIndex = 25;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(5, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(70, 13);
            this.label18.TabIndex = 24;
            this.label18.Text = "Сорт зерна:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(3, 10);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(81, 13);
            this.label19.TabIndex = 23;
            this.label19.Text = "Тип продукта:";
            // 
            // textBoxTypeCereal
            // 
            this.textBoxTypeCereal.Location = new System.Drawing.Point(6, 31);
            this.textBoxTypeCereal.Name = "textBoxTypeCereal";
            this.textBoxTypeCereal.Size = new System.Drawing.Size(214, 22);
            this.textBoxTypeCereal.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(942, 442);
            this.Controls.Add(this.panelDrinks);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.AnimalProducts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxDataManufacture);
            this.Controls.Add(this.textBoxShelfLife);
            this.Controls.Add(this.textBoxCal);
            this.Controls.Add(this.textBoxProductName);
            this.Controls.Add(this.comboBoxMain);
            this.Controls.Add(this.panelVegetableProducts);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.AnimalProducts.ResumeLayout(false);
            this.AnimalProducts.PerformLayout();
            this.panelMilck.ResumeLayout(false);
            this.panelMilck.PerformLayout();
            this.panelMeat.ResumeLayout(false);
            this.panelMeat.PerformLayout();
            this.panelDrinks.ResumeLayout(false);
            this.panelDrinks.PerformLayout();
            this.panelVegetableProducts.ResumeLayout(false);
            this.panelVegetableProducts.PerformLayout();
            this.panelFlour.ResumeLayout(false);
            this.panelFlour.PerformLayout();
            this.panelCereal.ResumeLayout(false);
            this.panelCereal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxMain;
        private System.Windows.Forms.TextBox textBoxProductName;
        private System.Windows.Forms.TextBox textBoxCal;
        private System.Windows.Forms.TextBox textBoxShelfLife;
        private System.Windows.Forms.TextBox textBoxDataManufacture;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel AnimalProducts;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.TextBox textBoxAnimal;
        private System.Windows.Forms.ComboBox comboBoxReadyToEat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelMilck;
        private System.Windows.Forms.ComboBox comboBoxLactose;
        private System.Windows.Forms.TextBox textBoxFatness;
        private System.Windows.Forms.TextBox textBoxTypeMilck;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel panelMeat;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox comboBoxFreez;
        private System.Windows.Forms.TextBox textBoxMeatType;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Panel panelDrinks;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox textBoxTypeDrink;
        private System.Windows.Forms.ComboBox comboBoxAlcohol;
        private System.Windows.Forms.ComboBox comboBoxGaz;
        private System.Windows.Forms.ComboBox comboBoxdrinkRady;
        private System.Windows.Forms.Panel panelVegetableProducts;
        private System.Windows.Forms.TextBox textBoxVitamins;
        private System.Windows.Forms.ComboBox comboBoxGMO;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panelCereal;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox textBoxTypeCereal;
        private System.Windows.Forms.TextBox textBoxSortCereal;
        private System.Windows.Forms.Panel panelFlour;
        private System.Windows.Forms.TextBox textBoxSortFlour;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox textBoxTypeFlour;
        private System.Windows.Forms.ComboBox comboBoxSugar;
        private System.Windows.Forms.Label label22;
    }
}

