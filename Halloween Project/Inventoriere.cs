using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Halloween_Project
{
    class Inventoriere
    {
        enum Item_Types
        {
            Knife,
            Rock,
            Door,
            Pumpkin,
            Apple,
            Bucket,
            Shoes,
            Jacket,
            END
        }
        Dictionary<Item_Types, int> items = new Dictionary<Item_Types, int>();
        
        public Inventoriere()
        {
            for (int i = 0; i < Convert.ToInt32(Item_Types.END); i++)
            {
                items.Add((Item_Types)i, 0);
            }
        }

        public void AddItem(string ii) //takes a string and adds an item counter if said string corresponds to an enum
            //error checking added? must test later, does NOT send error message... unsure if there will be one added
        {
            if (Enum.TryParse(ii, out Item_Types test))
                items[(Item_Types)Enum.Parse(typeof(Item_Types), ii)] = 1;
        }

        public void RemoveItem(string ii) //takes a string and removes an item if it matches an already existing item counted in the inventory
        {
            if (items[(Item_Types)Enum.Parse(typeof(Item_Types), ii)] > 0)
            {
                items[(Item_Types)Enum.Parse(typeof(Item_Types), ii)] = 0;
            }
        }
        /*Item_Types ConvertInteger(int i)
        {
        // ((Item_Types)Enum.Parse(typeof(Item_Types), Convert.ToString(i)))
            return Item_Types.((Item_Types)i);
        }*/

        public string ListItems() //lists all items in the dictionary with positive values (not null)
        {
            string temp = "";
            for (int i = 0; i < Convert.ToInt32(Item_Types.END); i++)
            {
                /*if(Enum.TryParse(Convert.ToString(i), out Item_Types test))
                {

                }*/
                if (items[(Item_Types)Enum.Parse(typeof(Item_Types), Convert.ToString(i))] > 0)
                {
                    //temp += Enum.(Item_Types.());
                    temp += ((Item_Types)i).ToString() + items[(Item_Types)Enum.Parse(typeof(Item_Types), Convert.ToString(i))] + "\n";
                }
            }
            return temp;
        }

        public bool HaveItem(string ii) //to check if a specific item is in the inventory
        {
            if (items[(Item_Types)Enum.Parse(typeof(Item_Types), ii)] > 0)
            {
                return true;
            }
            else
                return false;
        }
    }
}
