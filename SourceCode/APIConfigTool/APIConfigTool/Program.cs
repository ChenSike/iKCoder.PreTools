using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iKCoder_Platform_SDK_Kit;
using System.Xml;

namespace APIConfigTool
{
    class Program
    {      

        static void Main(string[] args)
        {
            class_Base_Config _objectConfig = new class_Base_Config();
            Console.WriteLine("Welcome to use Platform api config tool.");
            Console.WriteLine("Version : 2016.0.1");
            while(true)
            {
                string command = "";
                Console.Write(">>>: ");
                command = Console.ReadLine();
                if (command == "exit")
                {
                    string isSave = "yes";
                    Console.WriteLine("Do you want to save the config file before you quit?(type yes):");
                    isSave = Console.ReadLine();
                    if (isSave == "yes")
                        _objectConfig.DoSave();
                    Console.WriteLine("Goodbye.");
                    Environment.Exit(0);
                }
                else if (command == "create new file")
                {
                    string fileName = "";
                    while (fileName == "")
                    {
                        Console.WriteLine(">| confile file path : ");
                        fileName = Console.ReadLine();
                    }
                    if (_objectConfig.CreateNewConfigDocument(fileName))
                        Console.WriteLine(">| created new file :" + fileName);
                    else
                        Console.WriteLine(">| faild to create new file.");
                }
                else if(command=="open")
                {
                    string fileName = "";
                    while (fileName == "")
                    {
                        Console.WriteLine(">| config file path : ");
                        fileName = Console.ReadLine();
                    }
                    if (_objectConfig.DoOpen(fileName))
                        Console.WriteLine(">| opened new file :" + fileName);
                    else
                        Console.WriteLine(">| faild to open the file.");
                }
                else if (command == "DES mode On")
                {
                    string DESKey = "";
                    Console.WriteLine(">| DES Key Value : ");
                    DESKey = Console.ReadLine();
                    _objectConfig.SwitchToDESModeON(DESKey);
                    Console.WriteLine(">| DES Mode On. ");
                }
                else if(command == "DES mode Off")
                {
                    Console.WriteLine(">| DES Mode Off. ");
                }
                else if (command == "create new session")
                {
                    string sessionName = "";
                    string sessionValue = "";
                    while (sessionName == "")
                    {
                        Console.WriteLine(">| session name : ");
                        sessionName = Console.ReadLine();                        
                    }
                    Console.WriteLine(">| session value : ");
                    sessionValue = Console.ReadLine();                    
                    _objectConfig.CreateNewSession(sessionName, sessionValue);
                    Console.WriteLine(">| created new session.");
                }
                else if (command == "remove session")
                {
                    string sessionName = "";                  
                    while (sessionName == "")
                    {
                        Console.WriteLine(">| session name : ");
                        sessionName = Console.ReadLine();
                    }
                    _objectConfig.RemoveSession(sessionName);
                    Console.WriteLine(">| removed the active session.");
                }
                else if (command == "set session attr value")
                {
                    string sessionName = "";
                    string attrName = "";
                    string attrValue = "";
                     while (sessionName == "")
                    {
                        Console.WriteLine(">| session name : ");
                        sessionName = Console.ReadLine();
                    }
                    while (attrName == "")
                    {
                        Console.WriteLine(">| attr name : ");
                        attrName = Console.ReadLine();
                    }
                    Console.WriteLine(">| attr value : ");
                    attrValue = Console.ReadLine();                   
                    if(_objectConfig.SetSessionAttr(sessionName, attrName, attrValue))
                        Console.WriteLine(">| setted new attr value.");
                    else
                        Console.WriteLine(">| faild to set attr value.");
                }
                else if (command == "remove attr")
                {
                    string sessionName = "";
                    string attrName = "";                   
                    while (sessionName == "")
                    {
                        Console.WriteLine(">| session name : ");
                        sessionName = Console.ReadLine();
                    }
                    while (attrName == "")
                    {
                        Console.WriteLine(">| attr name : ");
                        attrName = Console.ReadLine();
                    }                   
                    if (_objectConfig.RemoveSessionAttr(sessionName, attrName))
                        Console.WriteLine(">| removed new attr value.");
                    else
                        Console.WriteLine(">| faild to remove attr value.");
                }
                else if (command == "create new item")
                {
                    string sessionName = "";                    
                    while (sessionName == "")
                    {
                        Console.WriteLine(">| session name : ");
                        sessionName = Console.ReadLine();
                    }
                    XmlNode activeSessionNode = _objectConfig.GetSessionNode(sessionName);
                    if(activeSessionNode == null)
                    {
                        Console.WriteLine(">| can't find the active session node.");
                        continue;
                    }
                    while(true)
                    {
                        string itemName = "" ;
                        string itemValue = "";                        
                        Console.WriteLine(">| new item name : ");
                        itemName = Console.ReadLine();
                        if(itemName == "exit create item")
                            break;
                        if (string.IsNullOrEmpty(itemName))
                            continue;
                        Console.WriteLine(">| new item value : ");
                        itemName = Console.ReadLine();                       
                        _objectConfig.CreateItem(activeSessionNode, itemName, itemValue);
                        Console.WriteLine(">| created new item. ");
                    }                  
                      
                }
                else if (command == "save file")
                {
                    _objectConfig.DoSave();
                    Console.WriteLine(">| saved file. ");
                }
                else if (command == "set item attr value")
                {
                    string sessionName = "";
                    while (sessionName == "")
                    {
                        Console.WriteLine(">| session name : ");
                        sessionName = Console.ReadLine();
                    }
                    XmlNode activeSessionNode = _objectConfig.GetSessionNode(sessionName);
                    if (activeSessionNode == null)
                    {
                        Console.WriteLine(">| can't find the active session node.");
                        continue;
                    }
                    string itemName = "";
                    string itemAttrName = "";
                    string itemAttrValue = "";
                    Console.WriteLine(">| item name : ");
                    itemName = Console.ReadLine();
                    Console.WriteLine(">| item attr name : ");
                    itemAttrName = Console.ReadLine();
                    Console.WriteLine(">| item attr value : ");
                    itemAttrValue = Console.ReadLine();                   
                    XmlNode activeItemNode = _objectConfig.GetItemNode(activeSessionNode,itemName);
                    if(_objectConfig.SetItemAttr(activeItemNode, itemAttrName, itemAttrValue))
                        Console.WriteLine(">| setted new item attr value.");
                    else
                        Console.WriteLine(">| faild to set item attr value.");

                }
                else if(command == "get session value")
                {
                    string sessionName = "";
                    while (sessionName == "")
                    {
                        Console.WriteLine(">| session name : ");
                        sessionName = Console.ReadLine();
                    }                    
                    Console.WriteLine(">| session value : " + _objectConfig.GetSessionValue(sessionName));
                }
                else if(command == "get session attr value")
                {
                    string sessionName = "";
                    string attrName = "";
                    while (sessionName == "")
                    {
                        Console.WriteLine(">| session name : ");
                        sessionName = Console.ReadLine();
                    }
                    while (attrName == "")
                    {
                        Console.WriteLine(">| attr name : ");
                        attrName = Console.ReadLine();
                    }                  
                    XmlNode activeSessionNode = _objectConfig.GetSessionNode(sessionName);
                    Console.WriteLine(">| attr : @" + attrName + " value : " + _objectConfig.GetAttrValue(activeSessionNode, attrName));
                }                     
                else
                    Console.WriteLine("<<< Invalidate Command");
            }
        }
    }
}
