/*******************************************************************
* Name: Greg Arnold
* Date:
* Assignment: CIS317 Week 3 GP – Constructors
*
* This class demonstrates using a default constructor as it provides
* no constructor otherwise. As there are no constructors provided to
* set the class's properties, class properties are given default values.
* The ToString method provides a formatted representation of the Date2
* properties; the SetDate2 method allows the user to specify a date
* using a string formatted as dd/MM/yyyy - invalid formats will result
* in an error message.
*/
public class Date2 {
    private string Datestring = "No date specified";
    private DateTime StoredDate = new DateTime();

    public void SetDate2(string datestring) {
        //Let's see if it's a real date 
        if (System.DateTime.TryParse(datestring, out StoredDate))
        {
            Datestring = datestring;
        }
        else
        {
            Datestring = "Invalid date format. Value specified was: "
                + datestring;
            StoredDate = new DateTime();
        }
    }
    public override string ToString() {
        return string.Format(
            "Date string Value: {0}\nStored Date Value: {1}\n",
            Datestring, StoredDate.ToString());
    }
    }