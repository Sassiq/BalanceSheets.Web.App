# BalanceSheets.Web.App
## Summary
Asp.Net MVC application based on EF Core and MS SQL server. App provides opportunities to work with bank sheets.  
In this app you can:
- Select bank sheet through user-friendly interface and view it
- Import new bank sheets from your device
  
## Demonstation of work  
- *Start page.*  
Here you can click the bank you want to view. Also you can click import to import new bank sheet.  
![image](https://user-images.githubusercontent.com/62505206/198687903-5e37521c-ccb4-4dbb-a00b-48e62617e965.png)  
  
- *Import page.*
Here you can select bank sheet from your device by clicking button "Choose File" and then "Submit".  
![image](https://user-images.githubusercontent.com/62505206/198688595-5e3759d8-935f-4fe0-9948-ff67cd3877e7.png)  
  
- *Bank sheet view page.*  
Here you can view all information in sheet.  
![image](https://user-images.githubusercontent.com/62505206/198688928-214335ce-b8a2-40de-ac51-b7c6397bfb52.png)  
  
- *Bank sheet view page. The second screen.*  
App counts sum of every Class columns.  
![image](https://user-images.githubusercontent.com/62505206/198689339-e80ef023-6e26-45c8-849b-3f65fadb2769.png)  
  
## Created database intoduction 
There are five entities in database:
- *Banks*  
![image](https://user-images.githubusercontent.com/62505206/198686719-104c7ec0-98e4-4aa0-990c-44764ce53b98.png) 
  
- *FinancialClasses*  
![image](https://user-images.githubusercontent.com/62505206/198687055-93e7d71e-de9b-4158-a222-1f011cce39c3.png)
  
- *Accounts*  
![image](https://user-images.githubusercontent.com/62505206/198686886-759a4d94-48e5-4eba-808f-b2984238859f.png)
  
- *Balances*  
![image](https://user-images.githubusercontent.com/62505206/198687331-ecf51438-a121-48e8-bd38-2adf1b487a1f.png)  
  
- *MoneyTurnovers*  
![image](https://user-images.githubusercontent.com/62505206/198687396-928ca83c-ec3e-4729-89f5-4d44398190b5.png)  
  
## Used NuGet packages:
- IronXl.Excel
- Microsoft.EntityFramework
- Microsoft.EntityFrameworkCore.SqlServer
- Microsoft.EntityFrameworkCore.Design
- Microsoft.EntityFrameworkCore.Tools
