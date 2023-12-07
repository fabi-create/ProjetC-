/*
 * Created by SharpDevelop.
 * User: HP
 * Date: 22/08/2023
 * Time: 11:02
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace ProjetRestauration
{
	/// <summary>
	/// Description of ComboBoxItem.
	/// </summary>
	public class ComboBoxItem
	{
		
		 public int ID { get; set; }
        public string Name { get; set; }

        public ComboBoxItem(int id, string name)
        {
            ID = id;
            Name = name;
        }

        public override string ToString()
        {
            return ID.ToString(); // Ceci est ce qui sera affiché dans la ComboBox
        }
	}
}
