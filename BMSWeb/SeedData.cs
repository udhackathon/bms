using BMS.Core.Entities;
using BMS.Infrastructure.Data;
using System;
using System.Collections.Generic;

namespace BMS.Web
{
  public static class SeedData
  {
    public static void PopulateTestData(AppDbContext dbContext)
    {
      //Remove Transaction data
      foreach (var inv in dbContext.Inventory)
      {
        dbContext.Remove(inv);
      }
      foreach (var inventoryLoc in dbContext.InventoryLocation)
      {
        dbContext.Remove(inventoryLoc);
      }

      //Remove Master data
      foreach (var usr in dbContext.User)
      {
        dbContext.Remove(usr);
      }
      foreach (var location in dbContext.Location)
      {
        dbContext.Remove(location);
      }
      foreach (var wearHouse in dbContext.Warehouse)
      {
        dbContext.Remove(wearHouse);
      }
      foreach (var binloc in dbContext.BinLocation)
      {
        dbContext.Remove(binloc);
      }
      foreach (var partDetail in dbContext.PartDetails)
      {
        dbContext.Remove(partDetail);
      }

      //Save Changes
      dbContext.SaveChanges();

      //Add Master data
      var user1 = new User() {  Name = "User1", Role = Role.Admin, CreatedOn = DateTime.Now };
      var user2 = new User() {  Name = "User2", Role = Role.Admin, CreatedOn = DateTime.Now };
      dbContext.User.Add(user1);
      dbContext.User.Add(user2);
      
      //Add Master data
      var location1 = new Location() {  Name = "Ageo", Description = "AgeoDescription", CreatedBy = user1, CreatedOn = DateTime.Now };
      var location2 = new Location() {  Name = "India", Description = "IndiaDescription", CreatedBy = user1, CreatedOn = DateTime.Now };
      dbContext.Location.Add(location1);
      dbContext.Location.Add(location2);

      var warehouse1 = new Warehouse() {  Name = "Wearhouse1", Description = "W1Description", Location = location1, CreatedBy = user1, CreatedOn = DateTime.Now };
      //var warehouse2 = new Warehouse() {  Name = "Wearhouse2", Description = "W2Description", Location = location2, CreatedBy = user1, CreatedOn = DateTime.Now };
      dbContext.Warehouse.Add(warehouse1);
      //dbContext.Warehouse.Add(warehouse2);

      var binLocation1 = new BinLocation() {  Name = "C903370A00", Description = "BinLoc1Desc", BinType = BinningType.Prime, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation2 = new BinLocation() {  Name = "C903230B00", Description = "BinLoc2Desc", BinType = BinningType.Prime, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation3 = new BinLocation() { Name = "C903120B00", Description = "BinLoc3Desc", BinType = BinningType.Prime, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation4 = new BinLocation() { Name = "C902170A00", Description = "BinLoc4Desc", BinType = BinningType.Prime, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation5 = new BinLocation() { Name = "C902020A00", Description = "BinLoc5Desc", BinType = BinningType.Prime, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation6 = new BinLocation() { Name = "C901360A00", Description = "BinLoc6Desc", BinType = BinningType.Prime, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation7 = new BinLocation() { Name = "C903200B", Description = "BinLoc7Desc", BinType = BinningType.Prime, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation8 = new BinLocation() { Name = "C902200B00", Description = "BinLoc8Desc", BinType = BinningType.Prime, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation9 = new BinLocation() { Name = "C902120B00", Description = "BinLoc9Desc", BinType = BinningType.Prime, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation10 = new BinLocation() { Name = "C902080A00", Description = "BinLoc10Desc", BinType = BinningType.Prime, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation11 = new BinLocation() { Name = "C901370B00", Description = "BinLoc11Desc", BinType = BinningType.Prime, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation12 = new BinLocation() { Name = "C901110B00", Description = "BinLoc12Desc", BinType = BinningType.Prime, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation13 = new BinLocation() { Name = "C901090B00", Description = "BinLoc13Desc", BinType = BinningType.Prime, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation14 = new BinLocation() { Name = "C903400A00", Description = "BinLoc14Desc", BinType = BinningType.Prime, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation15 = new BinLocation() { Name = "C903300B", Description = "BinLoc15Desc", BinType = BinningType.Prime, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation16 = new BinLocation() { Name = "C903250B00", Description = "BinLoc16Desc", BinType = BinningType.Prime, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation17 = new BinLocation() { Name = "C903100A", Description = "BinLoc17Desc", BinType = BinningType.Prime, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation18 = new BinLocation() { Name = "C902140B00", Description = "BinLoc18Desc", BinType = BinningType.Prime, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation19 = new BinLocation() { Name = "Buffer1", Description = "BinLoc18Desc", BinType = BinningType.Buffer, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation20 = new BinLocation() { Name = "Buffer2", Description = "BinLoc18Desc", BinType = BinningType.Buffer, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation21 = new BinLocation() { Name = "Buffer3", Description = "BinLoc18Desc", BinType = BinningType.Buffer, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation22 = new BinLocation() { Name = "Buffer4", Description = "BinLoc18Desc", BinType = BinningType.Buffer, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation23 = new BinLocation() { Name = "Buffer5", Description = "BinLoc18Desc", BinType = BinningType.Buffer, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      var binLocation24 = new BinLocation() { Name = "Buffer6", Description = "BinLoc18Desc", BinType = BinningType.Buffer, Warehouse = warehouse1, CreatedBy = user1, CreatedOn = DateTime.Now };
      dbContext.BinLocation.Add(binLocation1);
      dbContext.BinLocation.Add(binLocation2);
      dbContext.BinLocation.Add(binLocation3);
      dbContext.BinLocation.Add(binLocation4);
      dbContext.BinLocation.Add(binLocation5);
      dbContext.BinLocation.Add(binLocation6);
      dbContext.BinLocation.Add(binLocation7);
      dbContext.BinLocation.Add(binLocation8);
      dbContext.BinLocation.Add(binLocation9);
      dbContext.BinLocation.Add(binLocation10);
      dbContext.BinLocation.Add(binLocation11);
      dbContext.BinLocation.Add(binLocation12);
      dbContext.BinLocation.Add(binLocation13);
      dbContext.BinLocation.Add(binLocation14);
      dbContext.BinLocation.Add(binLocation15);
      dbContext.BinLocation.Add(binLocation16);
      dbContext.BinLocation.Add(binLocation17);
      dbContext.BinLocation.Add(binLocation18);
      dbContext.BinLocation.Add(binLocation19);
      dbContext.BinLocation.Add(binLocation20);
      dbContext.BinLocation.Add(binLocation21);
      dbContext.BinLocation.Add(binLocation22);
      dbContext.BinLocation.Add(binLocation23);
      dbContext.BinLocation.Add(binLocation24);

      var part1 = new PartDetails() {  Name = "Part1", PartNo = "asd123", CreatedBy = user1, CreatedOn = DateTime.Now };
      var part2 = new PartDetails() {  Name = "Part2", PartNo = "asd124", CreatedBy = user1, CreatedOn = DateTime.Now };
      var part3 = new PartDetails() {  Name = "Part3", PartNo = "asd125", CreatedBy = user1, CreatedOn = DateTime.Now };
      dbContext.PartDetails.Add(part1);
      dbContext.PartDetails.Add(part2);
      dbContext.PartDetails.Add(part3);


      var inventoryLoc1 = new InventoryLocation() { BinLocation = binLocation1, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now }; 
      var inventoryLoc2 = new InventoryLocation() { BinLocation = binLocation2, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc3 = new InventoryLocation() { BinLocation = binLocation3, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc4 = new InventoryLocation() { BinLocation = binLocation4, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc5 = new InventoryLocation() { BinLocation = binLocation5, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc6 = new InventoryLocation() { BinLocation = binLocation6, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc7 = new InventoryLocation() { BinLocation = binLocation7, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc8 = new InventoryLocation() { BinLocation = binLocation8, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc9 = new InventoryLocation() { BinLocation = binLocation9, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc10 = new InventoryLocation() { BinLocation = binLocation10, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc11 = new InventoryLocation() { BinLocation = binLocation11, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc12 = new InventoryLocation() { BinLocation = binLocation12, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc13 = new InventoryLocation() { BinLocation = binLocation13, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc14 = new InventoryLocation() { BinLocation = binLocation14, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc15 = new InventoryLocation() { BinLocation = binLocation15, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc16 = new InventoryLocation() { BinLocation = binLocation16, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc17 = new InventoryLocation() { BinLocation = binLocation17, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc18 = new InventoryLocation() { BinLocation = binLocation18, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc19 = new InventoryLocation() { BinLocation = binLocation19, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc20 = new InventoryLocation() { BinLocation = binLocation20, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc21 = new InventoryLocation() { BinLocation = binLocation21, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc22 = new InventoryLocation() { BinLocation = binLocation22, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc23 = new InventoryLocation() { BinLocation = binLocation23, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };
      var inventoryLoc24 = new InventoryLocation() { BinLocation = binLocation24, Quantity = 50, CreatedBy = user1, CreatedOn = DateTime.Now };

      dbContext.InventoryLocation.Add(inventoryLoc1);
      dbContext.InventoryLocation.Add(inventoryLoc2);
      dbContext.InventoryLocation.Add(inventoryLoc3);
      dbContext.InventoryLocation.Add(inventoryLoc4);
      dbContext.InventoryLocation.Add(inventoryLoc5);
      dbContext.InventoryLocation.Add(inventoryLoc6);
      dbContext.InventoryLocation.Add(inventoryLoc7);
      dbContext.InventoryLocation.Add(inventoryLoc8);
      dbContext.InventoryLocation.Add(inventoryLoc9);
      dbContext.InventoryLocation.Add(inventoryLoc10);
      dbContext.InventoryLocation.Add(inventoryLoc11);
      dbContext.InventoryLocation.Add(inventoryLoc12);
      dbContext.InventoryLocation.Add(inventoryLoc13);
      dbContext.InventoryLocation.Add(inventoryLoc14);
      dbContext.InventoryLocation.Add(inventoryLoc15);
      dbContext.InventoryLocation.Add(inventoryLoc16);
      dbContext.InventoryLocation.Add(inventoryLoc17);
      dbContext.InventoryLocation.Add(inventoryLoc18);


      var inventory1 = new Inventory() {  QRCode="QR123456789",Warehouse=warehouse1, Description = "Description1", TotalQuantity = 100, Part = part1, InventoryLocations = new List<InventoryLocation>() { inventoryLoc1 , inventoryLoc2}, CreatedBy = user1, CreatedOn = DateTime.Now }; 
      dbContext.Inventory.Add(inventory1);


      //Save Changes
      dbContext.SaveChanges();
    }
  }
}
