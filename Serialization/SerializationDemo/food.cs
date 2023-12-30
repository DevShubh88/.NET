namespace MySeri; 
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;

[Serializable]   
public partial class food{
    
// public 
// public int item_id,company_id;
// public string item_name,item_unit;

public int item_id{
    set;get;
}
public int company_id{
    set;get;
}
public string item_name{
    set;get;
}
public string item_unit{
    set;get;
}

public food()
{
    // this.item_id=item_id;
    // this.company_id=company_id;
    // this.item_name=item_name;
    // this.item_unit=item_unit;

}
public food(int item_id,int company_id,string item_name,string item_unit)
{
    this.item_id=item_id;
    this.company_id=company_id;
    this.item_name=item_name;
    this.item_unit=item_unit;

}




// bool st=StoreData();






public List<food>  StoreData()
{
food f1=new food{item_id=1,item_name= "Jam", item_unit="bottle", company_id=455};
food f2=new food{item_id=14,item_name= "pichku", item_unit="packet", company_id=56};
food f3=new food{item_id=51,item_name= "Chutni", item_unit="bottle", company_id=765};
food f4=new food{item_id=13,item_name= "Curd", item_unit="bottle", company_id=67};

List<food> items=new List<food>();
items.Add(f1);
items.Add(f2);
items.Add(f3);
items.Add(f4);
return items;

}

}