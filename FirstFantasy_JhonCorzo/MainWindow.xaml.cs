using FirstFantasy_JhonCorzo.Classes;
using FirstFantasy_JhonCorzo.Classes.Characters;
using FirstFantasy_JhonCorzo.Classes.Inventory_and_Items;
using FirstFantasy_JhonCorzo.Classes.Weapons;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FirstFantasy_JhonCorzo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        BindingList<Characters> charCreated = new BindingList<Characters>();

        Characters characters;

        public MainWindow()
        {
            InitializeComponent();

            
        }

        private void btnCreate_Click(object sender, RoutedEventArgs e)
        {
            gridCharacter.Visibility = Visibility.Visible;
            gridInitial.Visibility = Visibility.Hidden;
            
        }

        private void btnSave1_Click(object sender, RoutedEventArgs e)
        {

            if (comboBoxGender.SelectedItem == null || textAge.Text == "" || textName.Text == "")
            {
                MessageBox.Show("Please choose all the atributes for your character.");
            }
            else
            {
                try
                {
                    int charAge = Convert.ToInt32(textAge.Text);

                    gridChar_1.Visibility = Visibility.Visible;
                    gridChar_2.Visibility = Visibility.Visible;
                }
                catch (Exception)
                {
                    MessageBox.Show("Please, put an allow age.");
                }
            }

        }

        private void comboBoxClass_DropDownClosed(object sender, EventArgs e)
        {
            gridChar_3.Visibility = Visibility.Visible;

            string selectedClass = "No selection";

            if (comboBoxClass.SelectedItem == null)
            {
                MessageBox.Show("Please choose a class for your character.");
            }
            else
            {
                selectedClass = comboBoxClass.Text;
                labelWeapon.Visibility = Visibility.Visible;
                labelWeaponD.Visibility = Visibility.Visible;
                textBlockWeaponD.Visibility = Visibility.Visible;
            }

            textBlockCharD.Text = selectedClass;

            if (selectedClass == "Archer")
            {
                if (textBlockWeaponD.Text == Bow.WDescription() || textBlockWeaponD.Text == Crossbow.WDescription())
                    textBlockWeaponD.Text = textBlockWeaponD.Text;
                else
                    textBlockWeaponD.Text = "";

                textBlockCharD.Text = Archer.Description();
                comboBoxArcherW.Visibility = Visibility.Visible;
                comboBoxWarriorW.Visibility = Visibility.Hidden;
                labelWoodenWand.Visibility = Visibility.Hidden;
                labelAngelStaff.Visibility = Visibility.Hidden;
                comboBoxArcherW.SelectedIndex = -1;
            }
            else if (selectedClass == "Cleric")
            {
                textBlockCharD.Text = Cleric.Description();
                textBlockWeaponD.Text = AngelStaff.WDescription();
                labelWoodenWand.Visibility = Visibility.Hidden;
                labelAngelStaff.Visibility = Visibility.Visible;
                comboBoxArcherW.Visibility = Visibility.Hidden;
                comboBoxWarriorW.Visibility = Visibility.Hidden;
            }
            else if (selectedClass == "Mage")
            {
                textBlockCharD.Text = Mage.Description();
                textBlockWeaponD.Text = WoodenWand.WDescription();
                labelAngelStaff.Visibility = Visibility.Hidden;
                labelWoodenWand.Visibility = Visibility.Visible;
                comboBoxArcherW.Visibility = Visibility.Hidden;
                comboBoxWarriorW.Visibility = Visibility.Hidden;
            }
            else if (selectedClass == "Warrior")
            {
                if (textBlockWeaponD.Text == Hammer.WDescription() || textBlockWeaponD.Text == Sword.WDescription())
                    textBlockWeaponD.Text = textBlockWeaponD.Text;
                else
                    textBlockWeaponD.Text = "";

                textBlockCharD.Text = Warrior.Description();
                comboBoxArcherW.Visibility = Visibility.Hidden;
                comboBoxWarriorW.Visibility = Visibility.Visible;
                labelWoodenWand.Visibility = Visibility.Hidden;
                labelAngelStaff.Visibility = Visibility.Hidden;
                comboBoxWarriorW.SelectedIndex = -1;


            }
            else
            {
                MessageBox.Show("No class selected");
            }



        }

        private void comboBoxWarriorW_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBoxWarriorW.SelectedItem == null)
                textBlockWeaponD.Text = "";
            else if (comboBoxWarriorW.Text == "Hammer")
            {
                textBlockWeaponD.Text = Hammer.WDescription();
            }
            else
            {
                textBlockWeaponD.Text = Sword.WDescription();
            }

        }

        private void comboBoxArcherW_DropDownClosed(object sender, EventArgs e)
        {
            if (comboBoxArcherW.SelectedItem == null)
                textBlockWeaponD.Text = "";
            else if (comboBoxArcherW.Text == "Bow")
            {
                textBlockWeaponD.Text = Bow.WDescription();
            }
            else
            {
                textBlockWeaponD.Text = Crossbow.WDescription();
            }
        }

        private void btnSave2_Click(object sender, RoutedEventArgs e)
        {
            if ((comboBoxClass.SelectedItem==null) ||(comboBoxArcherW.IsVisible == true && comboBoxArcherW.SelectedItem==null) || (comboBoxWarriorW.IsVisible==true && comboBoxWarriorW.SelectedItem==null ))
                MessageBox.Show("Please choose all the atributes for your character.");

            else
            {
                
                Weapon weapon = new Weapon();

                if (comboBoxClass.Text == "Warrior" )
                {
                    
                    if (comboBoxWarriorW.Text == "Sword")
                    {
                        weapon = new Sword();
                    }
                    else
                    {
                        weapon = new Hammer();
                    }                      
                    characters = new Warrior();
                    
                }      
                else if (comboBoxClass.Text == "Archer" )
                {
                    if (comboBoxArcherW.Text == "Bow")
                    {
                        weapon = new Bow();
                    }
                    else
                    {
                        weapon = new Crossbow();
                    }
                    characters = new Archer();
                    
                }
                else if (comboBoxClass.Text == "Mage")
                {
                    weapon = new WoodenWand();
                    characters = new Mage();
                }
                
                else 
                {
                    characters = new Cleric();
                    weapon = new AngelStaff();
                }

                SelectImage(comboBoxClass.Text,comboBoxGender.Text);

                characters.Name = textName.Text;
                characters.Genre = comboBoxGender.Text;
                characters.Age = Convert.ToInt32(textAge.Text);

                loadInventory(weapon, characters.inventory);

                if (btnOtherChars.IsVisible == true)
                {
                    for (int i = 0; i < charCreated.Count; i++)
                    {
                        if (charCreated[i].Name == characters.Name)
                        {
                            MessageBox.Show("This Character already exist, please choose other class.");

                            textName.Text = "";
                            gridChar_2.Visibility = Visibility.Hidden;
                            gridChar_3.Visibility = Visibility.Hidden;
                            comboBoxClass.SelectedIndex = -1;
                            comboBoxGender.SelectedIndex = -1;
                            textAge.Text = "";
                            break;
                        }
                        else
                        {
                            gridCharacterP.Visibility = Visibility.Visible;
                            gridCharacter.Visibility = Visibility.Hidden;

                            labelCharClass.Content = comboBoxClass.Text;
                            labelCharName.Content = textName.Text;
                        }
                    }
                }
                else
                {
                    gridCharacterP.Visibility = Visibility.Visible;
                    gridCharacter.Visibility = Visibility.Hidden;

                    labelCharClass.Content = comboBoxClass.Text;
                    labelCharName.Content = textName.Text;
                }
            }
         
            
           

        }

        private void btnCreateNewChar_Click(object sender, RoutedEventArgs e)
        {
            
            loadCharacters(characters, charCreated);



            textAge.Text = "";
            textName.Text = "";
            comboBoxGender.SelectedIndex = -1;
            comboBoxClass.SelectedIndex = -1;
            comboBoxArcherW.SelectedIndex = -1;
            comboBoxWarriorW.SelectedIndex = -1;
            textBlockWeaponD.Text = "";
            textBlockCharD.Text = "";
            comboBxItem.SelectedIndex = -1;  

            if (btnOtherChars.IsVisible == false)
                btnOtherChars.Visibility = Visibility.Visible;

            gridCharacter.Visibility = Visibility.Visible;
            gridCharacterP.Visibility = Visibility.Visible;
            gridChar_1.Visibility = Visibility.Visible;
            gridChar_2.Visibility = Visibility.Hidden;
            gridChar_3.Visibility = Visibility.Hidden;
            comboBoxArcherW.Visibility = Visibility.Hidden;
            comboBoxWarriorW.Visibility = Visibility.Hidden;
            labelWoodenWand.Visibility = Visibility.Hidden;
            labelAngelStaff.Visibility = Visibility.Hidden;
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

            Items items = dataGridInventory.SelectedItem as Items;

            if (items.Name=="Bow"|| items.Name == "Crossbow"|| items.Name == "Angel Staff"|| items.Name == "Hammer"|| items.Name == "Sword"|| items.Name == "Wooden Wand")
            {
                MessageBox.Show("You can't delete your main weapon.");
            }
            else
                characters.inventory.RemoveAt(dataGridInventory.SelectedIndex);

        }

        private void btnInventory_Click(object sender, RoutedEventArgs e)
        {
            gridInventory.Visibility = Visibility.Visible;
        }

        private void loadInventory(Items items, BindingList<Items> inventory)
        {
           
            inventory.Add(items);

            dataGridInventory.ItemsSource = inventory;

        }

        private void loadCharacters(Characters characters, BindingList<Characters> charCreated)
        {

            charCreated.Add(characters);

            dataGridOtherChar.ItemsSource = charCreated;

        }

        private void btnAddItem_Click(object sender, RoutedEventArgs e)
        {
            int amount = Convert.ToInt32(labelAmount.Text);
            Items item = new Items();

            if (amount == 0)
            {
                MessageBox.Show("Please select the amount of items ypu want to add.");
            }
            else
            {
                if(comboBxItem.SelectedItem == null)
                MessageBox.Show("Please select an item.");
                else
                {
                    if (comboBxItem.Text == "Damage Potion")
                    {
                        item = new DamagePotion(amount);
                    }
                    else if (comboBxItem.Text == "Iron Arrow")
                    {
                        item = new IronArrow(amount);
                    }
                    else if(comboBxItem.Text == "Magic Ring")
                    {
                        item = new MagicRing(amount);
                    }
                    else if (comboBxItem.Text == "Potion")
                    {
                        item = new Potion(amount);
                    }
                    else if (comboBxItem.Text == "Shield")
                    {
                        item = new Shield(amount);
                    }
                    else
                    {
                        item = new WoodenArrrow(amount);
                    }

                    loadInventory(item, characters.inventory);



                }
            }
                   
        }

        private void btnInventoryBack_Click(object sender, RoutedEventArgs e)
        {
            gridInventory.Visibility = Visibility.Hidden;
            gridOtherChar.Visibility = Visibility.Hidden;
            comboBxItem.SelectedIndex = -1;
            slAmount.Value = 0;
        }

        private void btnCharInfo_Click(object sender, RoutedEventArgs e)
        {
            if(btnOtherChars.IsVisible ==false)
                textBxCharInfo.Text = characters.CharacterInfo();

            gridCharacterIn.Visibility = Visibility.Visible;
        }

        private void btnCloseCharInfo_Click(object sender, RoutedEventArgs e)
        {
            gridCharacterIn.Visibility = Visibility.Hidden;
        }

        private void btnDeleteChar_Click(object sender, RoutedEventArgs e)
        {
            if (btnOtherChars.IsVisible == true)
            {
                gridOtherChar.Visibility = Visibility.Visible;
                textAge.Text = "";
                textName.Text = "";
                comboBoxGender.SelectedIndex = -1;
                comboBoxClass.SelectedIndex = -1;
                comboBoxArcherW.SelectedIndex = -1;
                comboBoxWarriorW.SelectedIndex = -1;
                textBlockWeaponD.Text = "";
                textBlockCharD.Text = "";


                gridCharacterP.Visibility = Visibility.Hidden;
                gridChar_1.Visibility = Visibility.Visible;
                gridChar_2.Visibility = Visibility.Hidden;
                gridChar_3.Visibility = Visibility.Hidden;
                comboBoxArcherW.Visibility = Visibility.Hidden;
                comboBoxWarriorW.Visibility = Visibility.Hidden;
                labelWoodenWand.Visibility = Visibility.Hidden;
                labelAngelStaff.Visibility = Visibility.Hidden;
            }
            else
            {
                textAge.Text = "";
                textName.Text = "";
                comboBoxGender.SelectedIndex = -1;
                comboBoxClass.SelectedIndex = -1;
                comboBoxArcherW.SelectedIndex = -1;
                comboBoxWarriorW.SelectedIndex = -1;
                textBlockWeaponD.Text = "";
                textBlockCharD.Text = "";


                gridCharacterP.Visibility = Visibility.Hidden;
                gridChar_1.Visibility = Visibility.Visible;
                gridChar_2.Visibility = Visibility.Hidden;
                gridChar_3.Visibility = Visibility.Hidden;
                comboBoxArcherW.Visibility = Visibility.Hidden;
                comboBoxWarriorW.Visibility = Visibility.Hidden;
                labelWoodenWand.Visibility = Visibility.Hidden;
                labelAngelStaff.Visibility = Visibility.Hidden;
                gridOtherChar.Visibility = Visibility.Hidden;
            }
            


        }
        public void SelectImage(string charac, string characGender)
        {
            BitmapImage bitmapImage = new BitmapImage();
            bitmapImage.BeginInit();

            if (charac == "Warrior")
            {
                if (characGender == "Male")
                    bitmapImage.UriSource = new Uri(@"C:\Users\NECSOFT\OneDrive\Desktop\Proyectos Visual\FirstFantasy_JhonCorzo\FirstFantasy_JhonCorzo\Pictures\WarriorM.png");

                else if (characGender == "Female")
                    bitmapImage.UriSource = new Uri(@"C:\Users\NECSOFT\OneDrive\Desktop\Proyectos Visual\FirstFantasy_JhonCorzo\FirstFantasy_JhonCorzo\Pictures\WarriorF.png");
            }
            else if (charac == "Archer")
            {
                if (characGender == "Male")
                    bitmapImage.UriSource = new Uri(@"C:\Users\NECSOFT\OneDrive\Desktop\Proyectos Visual\FirstFantasy_JhonCorzo\FirstFantasy_JhonCorzo\Pictures\ArcherM.png");

                else if (characGender == "Female")
                    bitmapImage.UriSource = new Uri(@"C:\Users\NECSOFT\OneDrive\Desktop\Proyectos Visual\FirstFantasy_JhonCorzo\FirstFantasy_JhonCorzo\Pictures\ArcherF.png");

                
            }
            else if (charac == "Mage")
            {
                if (characGender == "Male")
                    bitmapImage.UriSource = new Uri(@"C:\Users\NECSOFT\OneDrive\Desktop\Proyectos Visual\FirstFantasy_JhonCorzo\FirstFantasy_JhonCorzo\Pictures\MageM.png");

                else if (characGender == "Female")
                    bitmapImage.UriSource = new Uri(@"C:\Users\NECSOFT\OneDrive\Desktop\Proyectos Visual\FirstFantasy_JhonCorzo\FirstFantasy_JhonCorzo\Pictures\MageF.png");

            }

            else
            {
                if (characGender == "Male")
                    bitmapImage.UriSource = new Uri(@"C:\Users\NECSOFT\OneDrive\Desktop\Proyectos Visual\FirstFantasy_JhonCorzo\FirstFantasy_JhonCorzo\Pictures\ClericM.png");

                else if (characGender == "Female")
                    bitmapImage.UriSource = new Uri(@"C:\Users\NECSOFT\OneDrive\Desktop\Proyectos Visual\FirstFantasy_JhonCorzo\FirstFantasy_JhonCorzo\Pictures\ClericF.png");

            }

            bitmapImage.EndInit();
            imageChar.Source = bitmapImage;
        }
        private void btnOtherChars_Click(object sender, RoutedEventArgs e)
        {
            if (charCreated.Contains(characters)==false)
            {
                loadCharacters(characters, charCreated);
            }
            gridOtherChar.Visibility = Visibility.Visible;

        }
        private void btnSelectChar_Click(object sender, RoutedEventArgs e)
        {

            Characters characters1 = dataGridOtherChar.SelectedItem as Characters;

            SelectImage(characters1.CharClass, characters1.Genre);
            labelCharClass.Content = characters1.CharClass;
            labelCharName.Content = characters1.Name;
            textBxCharInfo.Text = characters1.CharacterInfo();
            dataGridInventory.ItemsSource = characters1.inventory;

            comboBxItem.SelectedIndex = -1;
            slAmount.Value = 0;

            gridCharacterP.Visibility = Visibility.Visible;
            gridOtherChar.Visibility = Visibility.Hidden;
            characters = characters1;
        }
        private void btnDeleteChar_Click_1(object sender, RoutedEventArgs e)
        {
            charCreated.RemoveAt(dataGridOtherChar.SelectedIndex);
        }

        private void btnAtack_Click(object sender, RoutedEventArgs e)
        {

            MessageBox.Show($"{characters.Name} made a powerful atack of {characters.Atack(characters.inventory[0])} damage, with his weapon {characters.inventory[0].Name}.");
        }
    }
}
