using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace POManager
{    
    class PartsDTO
    {
        int PartID;
        int POPartsID;
        int POPartsPartID;
        string PartNo;
        string PartName;
        string VendorName;
        string PartManufacture;
        string PartDrawingNumber;
        string PartMakerPN;
        string PartUnit;
        double PartUnitPrice;
        int POPartQuantity;
        double POPartTotalAmount;
        string PriceType;

        public PartsDTO() { }

        public PartsDTO(int PartID, int POPartsID, int POPartsPartID, string PartNo, string PartName, string VendorName, string PartManufacture,
                        string PartDrawingNumber, string PartMakerPN, string PartUnit, double PartUnitPrice, int POPartQuantity,
                        double POPartTotalAmount, string PriceType)
        {
            this.PartID = PartID;
            this.POPartsID = POPartsID;
            this.POPartsPartID = POPartsPartID;
            this.PartNo = PartNo;
            this.PartName = PartName;
            this.VendorName = VendorName;
            this.PartManufacture = PartManufacture;
            this.PartDrawingNumber = PartDrawingNumber;
            this.PartMakerPN = PartMakerPN;
            this.PartUnit = PartUnit;
            this.PartUnitPrice = PartUnitPrice;
            this.POPartQuantity = POPartQuantity;
            this.POPartTotalAmount = POPartTotalAmount;
            this.PriceType = PriceType;
        }

        public int getPartID()
        {
            return PartID;
        }
        public void setPartID(int PartID)
        {
            this.PartID = PartID;
        }
        public int getPOPartsID()
        {
            return POPartsID;
        }
        public void setPOPartsID(int POPartsID)
        {
            this.POPartsID = POPartsID;
        }
        public int getPOPartsPartID()
        {
            return POPartsPartID;
        }
        public void setPOPartsPartID(int POPartsPartID)
        {
            this.POPartsPartID = POPartsPartID;
        }
        public String getPartNo()
        {
            return PartNo;
        }
        public void setPartNo(String PartNo)
        {
            this.PartNo = PartNo;
        }
        public String getPartName()
        {
            return PartName;
        }
        public void setPartName(String PartName)
        {
            this.PartName = PartName;
        }
        public String getVendorName()
        {
            return VendorName;
        }
        public void setVendorName(String VendorName)
        {
            this.VendorName = VendorName;
        }
        public String getPartManufacture()
        {
            return PartManufacture;
        }
        public void setPartManufacture(String PartManufacture)
        {
            this.PartManufacture = PartManufacture;
        }
        public string getPartDrawingNumber()
        {
            return PartDrawingNumber;
        }
        public void setPartDrawingNumber(string PartDrawingNumber)
        {
            this.PartDrawingNumber = PartDrawingNumber;
        }
        public String getPartMakerPN()
        {
            return PartMakerPN;
        }
        public void setPartMakerPN(String PartMakerPN)
        {
            this.PartMakerPN = PartMakerPN;
        }
        public string getPartUnit()
        {
            return PartUnit;
        }
        public void setPartUnit(string PartUnit)
        {
            this.PartUnit = PartUnit;
        }
        public double getPartUnitPrice()
        {
            return PartUnitPrice;
        }
        public void setPartUnitPrice(double PartUnitPrice)
        {
            this.PartUnitPrice = PartUnitPrice;
        }
        public int getPOPartQuantity()
        {
            return POPartQuantity;
        }
        public void setPOPartQuantity(int POPartQuantity)
        {
            this.POPartQuantity = POPartQuantity;
        }
        public double getPOPartTotalAmount()
        {
            return POPartTotalAmount;
        }
        public void setPOPartTotalAmount(double POPartTotalAmount)
        {
            this.POPartTotalAmount = POPartTotalAmount;
        }
        public string getPriceType()
        {
            return PriceType;
        }
        public void setPriceType(string PriceType)
        {
            this.PriceType = PriceType;
        }
    }
}
