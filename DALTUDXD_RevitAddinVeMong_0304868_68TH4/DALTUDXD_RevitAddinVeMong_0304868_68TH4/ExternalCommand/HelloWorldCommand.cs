using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace DALTUDXD_RevitAddinVeMong_0304868_68TH4
{

    public class MainClass : IExternalApplication
    {
        // Both OnStartup and OnShutdown must be implemented as public method
        public Result OnStartup(UIControlledApplication application)
        {
            //Add a new ribbon tab
            application.CreateRibbonTab("DALTUDXD68TH4");

            // Add a new ribbon panel
            RibbonPanel ribbonPanel = application.CreateRibbonPanel("DALTUDXD68TH4", "NewRibbonPanel");


            //tạo 1 nút button
            // Create a push button to trigger a command add it to the ribbon panel.
            string thisAssemblyPath = Assembly.GetExecutingAssembly().Location;

            PushButtonData buttonData = new PushButtonData("cmdHelloWorld",
               "Hello World", thisAssemblyPath, "DALTUDXD_RevitAddinVeMong_0304868_68TH4.ExternalCommands.HelloWorldCommand");

            PushButton pushButton = ribbonPanel.AddItem(buttonData) as PushButton;

            // Optionally, other properties may be assigned to the button
            // a) tool-tip
            pushButton.ToolTip = "Say hello to the entire world.";

            // b) large bitmap
            Uri uriImage = new Uri(@"D:\Git\DALTUDTXD_RevitAddinVeMong_0304868_68TH4\DALTUDXD_RevitAddinVeMong_0304868_68TH4\DALTUDXD_RevitAddinVeMong_0304868_68TH4\Assets\Icons\Cut_16px.png");
            BitmapImage largeImage = new BitmapImage(uriImage);
            pushButton.LargeImage = largeImage;
      
        //tạo 1 nút button show Bóc tách khối lượng
        //dữ liệu nút
        PushButtonData buttonData_BoctachKL = new PushButtonData("cmdData_BoctachKL",
               "Quantity take-off", thisAssemblyPath, "DALTUDXD_RevitAddinVeMong_0304868_68TH4.ExternalCommands.BocTachKhoiLuongCommand");
            //khai báo pushbutton thêm vào ribbonpanel
            PushButton pushButton_BoctachKL = ribbonPanel.AddItem(buttonData_BoctachKL) as PushButton;


            return Result.Succeeded;
        }

        public Result OnShutdown(UIControlledApplication application)
        {
            // nothing to clean up in this simple case
            return Result.Succeeded;
        }
    }
}
