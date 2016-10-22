using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeCamp.SmoDemo._03_CreateTables
{
    class Program
    {
        static void Main(string[] args)
        {
            Server server = new Server("localhost");

            Database database = server.Databases["SmoDemoDatabase"];

            CreateCustomerTable(database);
            CreatePurchaseOrderTable(database);

            Console.WriteLine("Finished");
            Console.ReadKey();
        }

        private static void CreatePurchaseOrderTable(Database database)
        {
            Table purchaseOrdersTable = new Table(database, "PurchaseOrders");
            purchaseOrdersTable.Schema = "dbo";

            Column idColumn = new Column(purchaseOrdersTable, "Id", DataType.Int);
            idColumn.Identity = true;
            idColumn.IdentityIncrement = 1;
            idColumn.IdentitySeed = 1;

            Column customerIdColumn = new Column(purchaseOrdersTable, "CustomerId", DataType.Int);
            Column orderDateTimeColumn = new Column(purchaseOrdersTable, "OrderDateTime", DataType.DateTime);
            Column orderTotalColumn = new Column(purchaseOrdersTable, "OrderTotal", DataType.Money);

            purchaseOrdersTable.Columns.Add(idColumn);
            purchaseOrdersTable.Columns.Add(customerIdColumn);
            purchaseOrdersTable.Columns.Add(orderDateTimeColumn);
            purchaseOrdersTable.Columns.Add(orderTotalColumn);

            ForeignKey foreignKey = new ForeignKey(purchaseOrdersTable, "FK_PurchaseOrders_CustomerId_Customers_Id");
            ForeignKeyColumn foreignKeyColumn = new ForeignKeyColumn(foreignKey, "CustomerId", "Id");
            foreignKey.ReferencedTable = "Customers";
            foreignKey.ReferencedTableSchema = "dbo";

            foreignKey.Columns.Add(foreignKeyColumn);

            purchaseOrdersTable.ForeignKeys.Add(foreignKey);

            Index index = new Index(purchaseOrdersTable, "PK_PurchaseOrders");
            index.IndexKeyType = IndexKeyType.DriPrimaryKey;

            IndexedColumn idIndexedColumn = new IndexedColumn(index, "Id");
            index.IndexedColumns.Add(idIndexedColumn);

            purchaseOrdersTable.Indexes.Add(index);

            purchaseOrdersTable.Create();
        }

        private static void CreateCustomerTable(Database database)
        {
            Table customersTable = new Table(database, "Customers");
            customersTable.Schema = "dbo";

            Column idColumn = new Column(customersTable, "Id", DataType.Int);
            idColumn.Identity = true;
            idColumn.IdentityIncrement = 1;
            idColumn.IdentitySeed = 1;

            Column nameColumn = new Column(customersTable, "Name", DataType.VarChar(200));
            nameColumn.Nullable = false;

            Column addressColumn = new Column(customersTable, "Address", DataType.VarChar(4000));
            Column cityColumn = new Column(customersTable, "City", DataType.VarChar(50));
            Column stateColumn = new Column(customersTable, "State", DataType.Char(2));
            Column zipColumn = new Column(customersTable, "Zip", DataType.VarChar(9));

            customersTable.Columns.Add(idColumn);
            customersTable.Columns.Add(nameColumn);
            customersTable.Columns.Add(addressColumn);
            customersTable.Columns.Add(cityColumn);
            customersTable.Columns.Add(stateColumn);
            customersTable.Columns.Add(zipColumn);

            Index index = new Index(customersTable, "PK_Customers");
            index.IndexKeyType = IndexKeyType.DriPrimaryKey;

            IndexedColumn idIndexedColumn = new IndexedColumn(index, "Id");
            index.IndexedColumns.Add(idIndexedColumn);

            customersTable.Indexes.Add(index);

            customersTable.Create();
        }
    }
}