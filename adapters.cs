//this is pulling all of your network adapters and displaying them in a combox
//I don't know why I am calling it here it should be in a main_load but doesn't make a big difference just starts eariler lolol xDD
List<string> AdapterList = new List<string>();
foreach (NetworkInterface nic in NetworkInterface.GetAllNetworkInterfaces())
{
    AdapterList.Add(nic.Name);
}
AdaptersCB.DataSource = AdapterList;