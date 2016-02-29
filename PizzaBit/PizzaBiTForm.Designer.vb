<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PizzaBiTForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCreatePizza = New System.Windows.Forms.Button()
        Me.btnAddCheese = New System.Windows.Forms.Button()
        Me.btnAddOnion = New System.Windows.Forms.Button()
        Me.btnAddMeat = New System.Windows.Forms.Button()
        Me.btnAddChicken = New System.Windows.Forms.Button()
        Me.btnCalculatePrice = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblCheesePortion = New System.Windows.Forms.Label()
        Me.lblOnionPortions = New System.Windows.Forms.Label()
        Me.lblMeatPortions = New System.Windows.Forms.Label()
        Me.lblChicken = New System.Windows.Forms.Label()
        Me.lblPrice = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmdCrustType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cmbSize = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmbPizza = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnCreatePizza
        '
        Me.btnCreatePizza.Location = New System.Drawing.Point(233, 300)
        Me.btnCreatePizza.Name = "btnCreatePizza"
        Me.btnCreatePizza.Size = New System.Drawing.Size(124, 23)
        Me.btnCreatePizza.TabIndex = 0
        Me.btnCreatePizza.Text = "Create New Pizza"
        Me.btnCreatePizza.UseVisualStyleBackColor = True
        '
        'btnAddCheese
        '
        Me.btnAddCheese.Location = New System.Drawing.Point(233, 142)
        Me.btnAddCheese.Name = "btnAddCheese"
        Me.btnAddCheese.Size = New System.Drawing.Size(113, 23)
        Me.btnAddCheese.TabIndex = 1
        Me.btnAddCheese.Text = "Add cheese"
        Me.btnAddCheese.UseVisualStyleBackColor = True
        '
        'btnAddOnion
        '
        Me.btnAddOnion.Location = New System.Drawing.Point(233, 171)
        Me.btnAddOnion.Name = "btnAddOnion"
        Me.btnAddOnion.Size = New System.Drawing.Size(113, 23)
        Me.btnAddOnion.TabIndex = 2
        Me.btnAddOnion.Text = "Add Onion"
        Me.btnAddOnion.UseVisualStyleBackColor = True
        '
        'btnAddMeat
        '
        Me.btnAddMeat.Location = New System.Drawing.Point(233, 200)
        Me.btnAddMeat.Name = "btnAddMeat"
        Me.btnAddMeat.Size = New System.Drawing.Size(113, 23)
        Me.btnAddMeat.TabIndex = 3
        Me.btnAddMeat.Text = "Add Meat"
        Me.btnAddMeat.UseVisualStyleBackColor = True
        '
        'btnAddChicken
        '
        Me.btnAddChicken.Location = New System.Drawing.Point(233, 229)
        Me.btnAddChicken.Name = "btnAddChicken"
        Me.btnAddChicken.Size = New System.Drawing.Size(113, 23)
        Me.btnAddChicken.TabIndex = 4
        Me.btnAddChicken.Text = "Add Chicken"
        Me.btnAddChicken.UseVisualStyleBackColor = True
        '
        'btnCalculatePrice
        '
        Me.btnCalculatePrice.Location = New System.Drawing.Point(233, 271)
        Me.btnCalculatePrice.Name = "btnCalculatePrice"
        Me.btnCalculatePrice.Size = New System.Drawing.Size(113, 23)
        Me.btnCalculatePrice.TabIndex = 5
        Me.btnCalculatePrice.Text = "Calculate the Price"
        Me.btnCalculatePrice.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 147)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(84, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cheese Portions"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(28, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Onion Portions"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(28, 205)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Meat Portions"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(28, 239)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Chicken Portions"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(30, 276)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Price"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblCheesePortion
        '
        Me.lblCheesePortion.AutoSize = True
        Me.lblCheesePortion.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCheesePortion.Location = New System.Drawing.Point(164, 147)
        Me.lblCheesePortion.Name = "lblCheesePortion"
        Me.lblCheesePortion.Size = New System.Drawing.Size(14, 13)
        Me.lblCheesePortion.TabIndex = 11
        Me.lblCheesePortion.Text = "0"
        '
        'lblOnionPortions
        '
        Me.lblOnionPortions.AutoSize = True
        Me.lblOnionPortions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOnionPortions.Location = New System.Drawing.Point(164, 176)
        Me.lblOnionPortions.Name = "lblOnionPortions"
        Me.lblOnionPortions.Size = New System.Drawing.Size(14, 13)
        Me.lblOnionPortions.TabIndex = 12
        Me.lblOnionPortions.Text = "0"
        '
        'lblMeatPortions
        '
        Me.lblMeatPortions.AutoSize = True
        Me.lblMeatPortions.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMeatPortions.Location = New System.Drawing.Point(164, 205)
        Me.lblMeatPortions.Name = "lblMeatPortions"
        Me.lblMeatPortions.Size = New System.Drawing.Size(14, 13)
        Me.lblMeatPortions.TabIndex = 13
        Me.lblMeatPortions.Text = "0"
        '
        'lblChicken
        '
        Me.lblChicken.AutoSize = True
        Me.lblChicken.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblChicken.Location = New System.Drawing.Point(164, 239)
        Me.lblChicken.Name = "lblChicken"
        Me.lblChicken.Size = New System.Drawing.Size(14, 13)
        Me.lblChicken.TabIndex = 14
        Me.lblChicken.Text = "0"
        '
        'lblPrice
        '
        Me.lblPrice.AutoSize = True
        Me.lblPrice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPrice.Location = New System.Drawing.Point(164, 276)
        Me.lblPrice.Name = "lblPrice"
        Me.lblPrice.Size = New System.Drawing.Size(14, 13)
        Me.lblPrice.TabIndex = 15
        Me.lblPrice.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(117, 9)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Pizza/Inventory"
        '
        'cmdCrustType
        '
        Me.cmdCrustType.FormattingEnabled = True
        Me.cmdCrustType.Location = New System.Drawing.Point(110, 71)
        Me.cmdCrustType.Name = "cmdCrustType"
        Me.cmdCrustType.Size = New System.Drawing.Size(121, 21)
        Me.cmdCrustType.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(30, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(55, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "CrustType"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(30, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(55, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Pizza Size"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbSize
        '
        Me.cmbSize.FormattingEnabled = True
        Me.cmbSize.Items.AddRange(New Object() {"Small", "Medium", "Large"})
        Me.cmbSize.Location = New System.Drawing.Point(110, 98)
        Me.cmbSize.Name = "cmbSize"
        Me.cmbSize.Size = New System.Drawing.Size(121, 21)
        Me.cmbSize.TabIndex = 19
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(28, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "Select Pizza"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cmbPizza
        '
        Me.cmbPizza.FormattingEnabled = True
        Me.cmbPizza.Items.AddRange(New Object() {"Margarita Pizza", "Create Your Own"})
        Me.cmbPizza.Location = New System.Drawing.Point(110, 35)
        Me.cmbPizza.Name = "cmbPizza"
        Me.cmbPizza.Size = New System.Drawing.Size(121, 21)
        Me.cmbPizza.TabIndex = 22
        '
        'PizzaBiTForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 329)
        Me.Controls.Add(Me.cmbPizza)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cmbSize)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmdCrustType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lblPrice)
        Me.Controls.Add(Me.lblChicken)
        Me.Controls.Add(Me.lblMeatPortions)
        Me.Controls.Add(Me.lblOnionPortions)
        Me.Controls.Add(Me.lblCheesePortion)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnCalculatePrice)
        Me.Controls.Add(Me.btnAddChicken)
        Me.Controls.Add(Me.btnAddMeat)
        Me.Controls.Add(Me.btnAddOnion)
        Me.Controls.Add(Me.btnAddCheese)
        Me.Controls.Add(Me.btnCreatePizza)
        Me.Name = "PizzaBiTForm"
        Me.Text = "Creating your pizza"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCreatePizza As System.Windows.Forms.Button
    Friend WithEvents btnAddCheese As System.Windows.Forms.Button
    Friend WithEvents btnAddOnion As System.Windows.Forms.Button
    Friend WithEvents btnAddMeat As System.Windows.Forms.Button
    Friend WithEvents btnAddChicken As System.Windows.Forms.Button
    Friend WithEvents btnCalculatePrice As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lblCheesePortion As System.Windows.Forms.Label
    Friend WithEvents lblOnionPortions As System.Windows.Forms.Label
    Friend WithEvents lblMeatPortions As System.Windows.Forms.Label
    Friend WithEvents lblChicken As System.Windows.Forms.Label
    Friend WithEvents lblPrice As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmdCrustType As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents cmbSize As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents cmbPizza As System.Windows.Forms.ComboBox

End Class
