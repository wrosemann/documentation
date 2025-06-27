//These declarations are fully qualified (could be put into the using statement:
VIZNET.Shared.DataElements.Collections.DataElementCollection __dec = VIZNET.Shared.DataElements.Engine.DataElementEngine.NewDataElementCollection();

//Create a DE with a value
DataElement __de = DataElementEngine.NewDataElement("a2.de");
__de.Value = 1223;

MethodReturnInfo __mri = MyConnection.UpdateDataElements(__dec);

//Check that the write was successful:
if (!__mri.Success) 
{
  MyApplication.ShowInformation("Write Failed: ",  __mri.ReturnInformation + " " + __de.Name);
}

