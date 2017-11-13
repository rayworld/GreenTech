﻿using HuaLiQin.Model;
using Ray.Framework.DBUtility;
using Ray.Framework.Encrypt;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Text;


namespace HuaLiQin.DAL
{
    #region t_ICItem
    public partial class t_ICItem
    {
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string fAlconItemID)
        {
            bool retVal = false;
            object recCount = SqlHelper.ExecuteScalar("SELECT Count(1) FROM t_ICItem WHERE FHelpCode = '" + fAlconItemID + "'", null);
            retVal = recCount != null && int.Parse(recCount.ToString()) > 0 ? true : false;

            return retVal;
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public HuaLiQin.Model.t_ICItem GetModel(string fAlconItemID)
        {

            HuaLiQin.Model.t_ICItem model = new HuaLiQin.Model.t_ICItem();
            DataTable dt = SqlHelper.ExecuteDataSet("SELECT TOP 1 * FROM t_ICItem WHERE fHelpCode='" + fAlconItemID + "'", null).Tables[0];
            if (dt.Rows.Count > 0)
            {
                return DataRowToModel(dt.Rows[0]);
            }
            else
            {
                return null;
            }
        }


        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public HuaLiQin.Model.t_ICItem DataRowToModel(DataRow row)
        {
            HuaLiQin.Model.t_ICItem model = new HuaLiQin.Model.t_ICItem();
            if (row != null)
            {
                if (row["FARAcctID"] != null && row["FARAcctID"].ToString() != "")
                {
                    model.FARAcctID = int.Parse(row["FARAcctID"].ToString());
                }
                if (row["FBrNo"] != null)
                {
                    model.FBrNo = row["FBrNo"].ToString();
                }
                if (row["FDeleted"] != null && row["FDeleted"].ToString() != "")
                {
                    model.FDeleted = int.Parse(row["FDeleted"].ToString());
                }
                if (row["FForSale"] != null && row["FForSale"].ToString() != "")
                {
                    if ((row["FForSale"].ToString() == "1") || (row["FForSale"].ToString().ToLower() == "true"))
                    {
                        model.FForSale = true;
                    }
                    else
                    {
                        model.FForSale = false;
                    }
                }
                if (row["FHelpCode"] != null)
                {
                    model.FHelpCode = row["FHelpCode"].ToString();
                }
                if (row["FItemID"] != null && row["FItemID"].ToString() != "")
                {
                    model.FItemID = int.Parse(row["FItemID"].ToString());
                }
                if (row["FModel"] != null)
                {
                    model.FModel = row["FModel"].ToString();
                }
                //if (row["FModifyTime"] != null && row["FModifyTime"].ToString() != "")
                //{
                //    model.FModifyTime = DateTime.Parse(row["FModifyTime"].ToString());
                //}
                if (row["FName"] != null)
                {
                    model.FName = row["FName"].ToString();
                }
                if (row["FNumber"] != null)
                {
                    model.FNumber = row["FNumber"].ToString();
                }
                if (row["FOmortize"] != null && row["FOmortize"].ToString() != "")
                {
                    model.FOmortize = int.Parse(row["FOmortize"].ToString());
                }
                if (row["FOmortizeScale"] != null && row["FOmortizeScale"].ToString() != "")
                {
                    model.FOmortizeScale = int.Parse(row["FOmortizeScale"].ToString());
                }
                if (row["FOrderMethod"] != null && row["FOrderMethod"].ToString() != "")
                {
                    model.FOrderMethod = int.Parse(row["FOrderMethod"].ToString());
                }
                if (row["FOrderPrice"] != null && row["FOrderPrice"].ToString() != "")
                {
                    model.FOrderPrice = decimal.Parse(row["FOrderPrice"].ToString());
                }
                if (row["FParentID"] != null && row["FParentID"].ToString() != "")
                {
                    model.FParentID = int.Parse(row["FParentID"].ToString());
                }
                if (row["FPerWastage"] != null && row["FPerWastage"].ToString() != "")
                {
                    model.FPerWastage = decimal.Parse(row["FPerWastage"].ToString());
                }
                if (row["FPlanClass"] != null && row["FPlanClass"].ToString() != "")
                {
                    model.FPlanClass = int.Parse(row["FPlanClass"].ToString());
                }
                if (row["FPlanPriceMethod"] != null && row["FPlanPriceMethod"].ToString() != "")
                {
                    model.FPlanPriceMethod = int.Parse(row["FPlanPriceMethod"].ToString());
                }
                if (row["FPriceFixingType"] != null && row["FPriceFixingType"].ToString() != "")
                {
                    model.FPriceFixingType = int.Parse(row["FPriceFixingType"].ToString());
                }
                if (row["FRP"] != null && row["FRP"].ToString() != "")
                {
                    model.FRP = int.Parse(row["FRP"].ToString());
                }
                if (row["FSalePriceFixingType"] != null && row["FSalePriceFixingType"].ToString() != "")
                {
                    model.FSalePriceFixingType = int.Parse(row["FSalePriceFixingType"].ToString());
                }
                if (row["FShortNumber"] != null)
                {
                    model.FShortNumber = row["FShortNumber"].ToString();
                }
                if (row["FStaCost"] != null && row["FStaCost"].ToString() != "")
                {
                    model.FStaCost = decimal.Parse(row["FStaCost"].ToString());
                }
                if (row["FTopID"] != null && row["FTopID"].ToString() != "")
                {
                    model.FTopID = int.Parse(row["FTopID"].ToString());
                }
                if (row["FAlias"] != null)
                {
                    model.FAlias = row["FAlias"].ToString();
                }
                if (row["FApproveNo"] != null)
                {
                    model.FApproveNo = row["FApproveNo"].ToString();
                }
                if (row["FAuxClassID"] != null && row["FAuxClassID"].ToString() != "")
                {
                    model.FAuxClassID = int.Parse(row["FAuxClassID"].ToString());
                }
                if (row["FDefaultLoc"] != null && row["FDefaultLoc"].ToString() != "")
                {
                    model.FDefaultLoc = int.Parse(row["FDefaultLoc"].ToString());
                }
                if (row["FDefaultReadyLoc"] != null && row["FDefaultReadyLoc"].ToString() != "")
                {
                    model.FDefaultReadyLoc = int.Parse(row["FDefaultReadyLoc"].ToString());
                }
                if (row["FEquipmentNum"] != null)
                {
                    model.FEquipmentNum = row["FEquipmentNum"].ToString();
                }
                if (row["FErpClsID"] != null && row["FErpClsID"].ToString() != "")
                {
                    model.FErpClsID = int.Parse(row["FErpClsID"].ToString());
                }
                if (row["FFullName"] != null)
                {
                    model.FFullName = row["FFullName"].ToString();
                }
                if (row["FHighLimit"] != null && row["FHighLimit"].ToString() != "")
                {
                    model.FHighLimit = decimal.Parse(row["FHighLimit"].ToString());
                }
                if (row["FIsEquipment"] != null && row["FIsEquipment"].ToString() != "")
                {
                    if ((row["FIsEquipment"].ToString() == "1") || (row["FIsEquipment"].ToString().ToLower() == "true"))
                    {
                        model.FIsEquipment = true;
                    }
                    else
                    {
                        model.FIsEquipment = false;
                    }
                }
                if (row["FIsSparePart"] != null && row["FIsSparePart"].ToString() != "")
                {
                    if ((row["FIsSparePart"].ToString() == "1") || (row["FIsSparePart"].ToString().ToLower() == "true"))
                    {
                        model.FIsSparePart = true;
                    }
                    else
                    {
                        model.FIsSparePart = false;
                    }
                }
                if (row["FLowLimit"] != null && row["FLowLimit"].ToString() != "")
                {
                    model.FLowLimit = decimal.Parse(row["FLowLimit"].ToString());
                }
                if (row["FOrderUnitID"] != null && row["FOrderUnitID"].ToString() != "")
                {
                    model.FOrderUnitID = int.Parse(row["FOrderUnitID"].ToString());
                }
                if (row["FPreDeadLine"] != null && row["FPreDeadLine"].ToString() != "")
                {
                    model.FPreDeadLine = int.Parse(row["FPreDeadLine"].ToString());
                }
                if (row["FProductUnitID"] != null && row["FProductUnitID"].ToString() != "")
                {
                    model.FProductUnitID = int.Parse(row["FProductUnitID"].ToString());
                }
                if (row["FQtyDecimal"] != null && row["FQtyDecimal"].ToString() != "")
                {
                    model.FQtyDecimal = int.Parse(row["FQtyDecimal"].ToString());
                }
                if (row["FSaleUnitID"] != null && row["FSaleUnitID"].ToString() != "")
                {
                    model.FSaleUnitID = int.Parse(row["FSaleUnitID"].ToString());
                }
                if (row["FSecCoefficient"] != null && row["FSecCoefficient"].ToString() != "")
                {
                    model.FSecCoefficient = decimal.Parse(row["FSecCoefficient"].ToString());
                }
                if (row["FSecInv"] != null && row["FSecInv"].ToString() != "")
                {
                    model.FSecInv = decimal.Parse(row["FSecInv"].ToString());
                }
                if (row["FSecUnitDecimal"] != null && row["FSecUnitDecimal"].ToString() != "")
                {
                    model.FSecUnitDecimal = int.Parse(row["FSecUnitDecimal"].ToString());
                }
                if (row["FSecUnitID"] != null && row["FSecUnitID"].ToString() != "")
                {
                    model.FSecUnitID = int.Parse(row["FSecUnitID"].ToString());
                }
                if (row["FSerialClassID"] != null && row["FSerialClassID"].ToString() != "")
                {
                    model.FSerialClassID = int.Parse(row["FSerialClassID"].ToString());
                }
                if (row["FSource"] != null && row["FSource"].ToString() != "")
                {
                    model.FSource = int.Parse(row["FSource"].ToString());
                }
                if (row["FSPID"] != null && row["FSPID"].ToString() != "")
                {
                    model.FSPID = int.Parse(row["FSPID"].ToString());
                }
                if (row["FSPIDReady"] != null && row["FSPIDReady"].ToString() != "")
                {
                    model.FSPIDReady = int.Parse(row["FSPIDReady"].ToString());
                }
                if (row["FStoreUnitID"] != null && row["FStoreUnitID"].ToString() != "")
                {
                    model.FStoreUnitID = int.Parse(row["FStoreUnitID"].ToString());
                }
                if (row["FTypeID"] != null && row["FTypeID"].ToString() != "")
                {
                    model.FTypeID = int.Parse(row["FTypeID"].ToString());
                }
                if (row["FUnitGroupID"] != null && row["FUnitGroupID"].ToString() != "")
                {
                    model.FUnitGroupID = int.Parse(row["FUnitGroupID"].ToString());
                }
                if (row["FUnitID"] != null && row["FUnitID"].ToString() != "")
                {
                    model.FUnitID = int.Parse(row["FUnitID"].ToString());
                }
                if (row["FUseState"] != null && row["FUseState"].ToString() != "")
                {
                    model.FUseState = int.Parse(row["FUseState"].ToString());
                }
                if (row["FABCCls"] != null)
                {
                    model.FABCCls = row["FABCCls"].ToString();
                }
                if (row["FAcctID"] != null && row["FAcctID"].ToString() != "")
                {
                    model.FAcctID = int.Parse(row["FAcctID"].ToString());
                }
                if (row["FAdminAcctID"] != null && row["FAdminAcctID"].ToString() != "")
                {
                    model.FAdminAcctID = int.Parse(row["FAdminAcctID"].ToString());
                }
                if (row["FAPAcctID"] != null && row["FAPAcctID"].ToString() != "")
                {
                    model.FAPAcctID = int.Parse(row["FAPAcctID"].ToString());
                }
                if (row["FBatchManager"] != null && row["FBatchManager"].ToString() != "")
                {
                    if ((row["FBatchManager"].ToString() == "1") || (row["FBatchManager"].ToString().ToLower() == "true"))
                    {
                        model.FBatchManager = true;
                    }
                    else
                    {
                        model.FBatchManager = false;
                    }
                }
                if (row["FBatchQty"] != null && row["FBatchQty"].ToString() != "")
                {
                    model.FBatchQty = decimal.Parse(row["FBatchQty"].ToString());
                }
                if (row["FBeforeExpire"] != null && row["FBeforeExpire"].ToString() != "")
                {
                    model.FBeforeExpire = int.Parse(row["FBeforeExpire"].ToString());
                }
                if (row["FBookPlan"] != null && row["FBookPlan"].ToString() != "")
                {
                    if ((row["FBookPlan"].ToString() == "1") || (row["FBookPlan"].ToString().ToLower() == "true"))
                    {
                        model.FBookPlan = true;
                    }
                    else
                    {
                        model.FBookPlan = false;
                    }
                }
                if (row["FCBBmStandardID"] != null && row["FCBBmStandardID"].ToString() != "")
                {
                    model.FCBBmStandardID = int.Parse(row["FCBBmStandardID"].ToString());
                }
                if (row["FCBRestore"] != null && row["FCBRestore"].ToString() != "")
                {
                    model.FCBRestore = int.Parse(row["FCBRestore"].ToString());
                }
                if (row["FCheckCycle"] != null && row["FCheckCycle"].ToString() != "")
                {
                    model.FCheckCycle = int.Parse(row["FCheckCycle"].ToString());
                }
                if (row["FCheckCycUnit"] != null && row["FCheckCycUnit"].ToString() != "")
                {
                    model.FCheckCycUnit = int.Parse(row["FCheckCycUnit"].ToString());
                }
                if (row["FClass"] != null && row["FClass"].ToString() != "")
                {
                    if ((row["FClass"].ToString() == "1") || (row["FClass"].ToString().ToLower() == "true"))
                    {
                        model.FClass = true;
                    }
                    else
                    {
                        model.FClass = false;
                    }
                }
                if (row["FCostAcctID"] != null && row["FCostAcctID"].ToString() != "")
                {
                    model.FCostAcctID = int.Parse(row["FCostAcctID"].ToString());
                }
                if (row["FCostDiffRate"] != null && row["FCostDiffRate"].ToString() != "")
                {
                    model.FCostDiffRate = decimal.Parse(row["FCostDiffRate"].ToString());
                }
                if (row["FCostProject"] != null && row["FCostProject"].ToString() != "")
                {
                    model.FCostProject = int.Parse(row["FCostProject"].ToString());
                }
                if (row["FDaysPer"] != null && row["FDaysPer"].ToString() != "")
                {
                    model.FDaysPer = int.Parse(row["FDaysPer"].ToString());
                }
                if (row["FDepartment"] != null && row["FDepartment"].ToString() != "")
                {
                    model.FDepartment = int.Parse(row["FDepartment"].ToString());
                }
                if (row["FGoodSpec"] != null && row["FGoodSpec"].ToString() != "")
                {
                    model.FGoodSpec = int.Parse(row["FGoodSpec"].ToString());
                }
                if (row["FISKFPeriod"] != null && row["FISKFPeriod"].ToString() != "")
                {
                    if ((row["FISKFPeriod"].ToString() == "1") || (row["FISKFPeriod"].ToString().ToLower() == "true"))
                    {
                        model.FISKFPeriod = true;
                    }
                    else
                    {
                        model.FISKFPeriod = false;
                    }
                }
                if (row["FIsSale"] != null && row["FIsSale"].ToString() != "")
                {
                    if ((row["FIsSale"].ToString() == "1") || (row["FIsSale"].ToString().ToLower() == "true"))
                    {
                        model.FIsSale = true;
                    }
                    else
                    {
                        model.FIsSale = false;
                    }
                }
                if (row["FIsSnManage"] != null && row["FIsSnManage"].ToString() != "")
                {
                    if ((row["FIsSnManage"].ToString() == "1") || (row["FIsSnManage"].ToString().ToLower() == "true"))
                    {
                        model.FIsSnManage = true;
                    }
                    else
                    {
                        model.FIsSnManage = false;
                    }
                }
                if (row["FIsSpecialTax"] != null && row["FIsSpecialTax"].ToString() != "")
                {
                    if ((row["FIsSpecialTax"].ToString() == "1") || (row["FIsSpecialTax"].ToString().ToLower() == "true"))
                    {
                        model.FIsSpecialTax = true;
                    }
                    else
                    {
                        model.FIsSpecialTax = false;
                    }
                }
                if (row["FKFPeriod"] != null && row["FKFPeriod"].ToString() != "")
                {
                    model.FKFPeriod = decimal.Parse(row["FKFPeriod"].ToString());
                }
                if (row["FLastCheckDate"] != null && row["FLastCheckDate"].ToString() != "")
                {
                    model.FLastCheckDate = DateTime.Parse(row["FLastCheckDate"].ToString());
                }
                if (row["FNote"] != null)
                {
                    model.FNote = row["FNote"].ToString();
                }
                if (row["FOIHighLimit"] != null && row["FOIHighLimit"].ToString() != "")
                {
                    model.FOIHighLimit = decimal.Parse(row["FOIHighLimit"].ToString());
                }
                if (row["FOILowLimit"] != null && row["FOILowLimit"].ToString() != "")
                {
                    model.FOILowLimit = decimal.Parse(row["FOILowLimit"].ToString());
                }
                if (row["FOrderRector"] != null && row["FOrderRector"].ToString() != "")
                {
                    model.FOrderRector = int.Parse(row["FOrderRector"].ToString());
                }
                if (row["FPickHighLimit"] != null && row["FPickHighLimit"].ToString() != "")
                {
                    model.FPickHighLimit = decimal.Parse(row["FPickHighLimit"].ToString());
                }
                if (row["FPickLowLimit"] != null && row["FPickLowLimit"].ToString() != "")
                {
                    model.FPickLowLimit = decimal.Parse(row["FPickLowLimit"].ToString());
                }
                if (row["FPlanPrice"] != null && row["FPlanPrice"].ToString() != "")
                {
                    model.FPlanPrice = decimal.Parse(row["FPlanPrice"].ToString());
                }
                if (row["FPOHghPrcMnyType"] != null && row["FPOHghPrcMnyType"].ToString() != "")
                {
                    model.FPOHghPrcMnyType = int.Parse(row["FPOHghPrcMnyType"].ToString());
                }
                if (row["FPOHighPrice"] != null && row["FPOHighPrice"].ToString() != "")
                {
                    model.FPOHighPrice = decimal.Parse(row["FPOHighPrice"].ToString());
                }
                if (row["FPriceDecimal"] != null && row["FPriceDecimal"].ToString() != "")
                {
                    model.FPriceDecimal = int.Parse(row["FPriceDecimal"].ToString());
                }
                if (row["FProfitRate"] != null && row["FProfitRate"].ToString() != "")
                {
                    model.FProfitRate = decimal.Parse(row["FProfitRate"].ToString());
                }
                if (row["FSaleAcctID"] != null && row["FSaleAcctID"].ToString() != "")
                {
                    model.FSaleAcctID = int.Parse(row["FSaleAcctID"].ToString());
                }
                if (row["FSalePrice"] != null && row["FSalePrice"].ToString() != "")
                {
                    model.FSalePrice = decimal.Parse(row["FSalePrice"].ToString());
                }
                if (row["FSaleTaxAcctID"] != null && row["FSaleTaxAcctID"].ToString() != "")
                {
                    model.FSaleTaxAcctID = int.Parse(row["FSaleTaxAcctID"].ToString());
                }
                if (row["FSOHighLimit"] != null && row["FSOHighLimit"].ToString() != "")
                {
                    model.FSOHighLimit = decimal.Parse(row["FSOHighLimit"].ToString());
                }
                if (row["FSOLowLimit"] != null && row["FSOLowLimit"].ToString() != "")
                {
                    model.FSOLowLimit = decimal.Parse(row["FSOLowLimit"].ToString());
                }
                if (row["FSOLowPrc"] != null && row["FSOLowPrc"].ToString() != "")
                {
                    model.FSOLowPrc = decimal.Parse(row["FSOLowPrc"].ToString());
                }
                if (row["FSOLowPrcMnyType"] != null && row["FSOLowPrcMnyType"].ToString() != "")
                {
                    model.FSOLowPrcMnyType = int.Parse(row["FSOLowPrcMnyType"].ToString());
                }
                if (row["FStockPrice"] != null && row["FStockPrice"].ToString() != "")
                {
                    model.FStockPrice = decimal.Parse(row["FStockPrice"].ToString());
                }
                if (row["FStockTime"] != null && row["FStockTime"].ToString() != "")
                {
                    if ((row["FStockTime"].ToString() == "1") || (row["FStockTime"].ToString().ToLower() == "true"))
                    {
                        model.FStockTime = true;
                    }
                    else
                    {
                        model.FStockTime = false;
                    }
                }
                if (row["FTaxRate"] != null && row["FTaxRate"].ToString() != "")
                {
                    model.FTaxRate = decimal.Parse(row["FTaxRate"].ToString());
                }
                if (row["FTrack"] != null && row["FTrack"].ToString() != "")
                {
                    model.FTrack = int.Parse(row["FTrack"].ToString());
                }
                if (row["FWWHghPrc"] != null && row["FWWHghPrc"].ToString() != "")
                {
                    model.FWWHghPrc = decimal.Parse(row["FWWHghPrc"].ToString());
                }
                if (row["FWWHghPrcMnyType"] != null && row["FWWHghPrcMnyType"].ToString() != "")
                {
                    model.FWWHghPrcMnyType = int.Parse(row["FWWHghPrcMnyType"].ToString());
                }
                if (row["FBackFlushSPID"] != null && row["FBackFlushSPID"].ToString() != "")
                {
                    model.FBackFlushSPID = int.Parse(row["FBackFlushSPID"].ToString());
                }
                if (row["FBackFlushStockID"] != null && row["FBackFlushStockID"].ToString() != "")
                {
                    model.FBackFlushStockID = int.Parse(row["FBackFlushStockID"].ToString());
                }
                if (row["FBatChangeEconomy"] != null && row["FBatChangeEconomy"].ToString() != "")
                {
                    model.FBatChangeEconomy = decimal.Parse(row["FBatChangeEconomy"].ToString());
                }
                if (row["FBatchAppendQty"] != null && row["FBatchAppendQty"].ToString() != "")
                {
                    model.FBatchAppendQty = decimal.Parse(row["FBatchAppendQty"].ToString());
                }
                if (row["FBatchSplit"] != null && row["FBatchSplit"].ToString() != "")
                {
                    model.FBatchSplit = decimal.Parse(row["FBatchSplit"].ToString());
                }
                if (row["FBatchSplitDays"] != null && row["FBatchSplitDays"].ToString() != "")
                {
                    model.FBatchSplitDays = int.Parse(row["FBatchSplitDays"].ToString());
                }
                if (row["FBatFixEconomy"] != null && row["FBatFixEconomy"].ToString() != "")
                {
                    model.FBatFixEconomy = decimal.Parse(row["FBatFixEconomy"].ToString());
                }
                if (row["FCharSourceItemID"] != null && row["FCharSourceItemID"].ToString() != "")
                {
                    model.FCharSourceItemID = int.Parse(row["FCharSourceItemID"].ToString());
                }
                if (row["FContainerName"] != null)
                {
                    model.FContainerName = row["FContainerName"].ToString();
                }
                if (row["FCtrlStraregy"] != null && row["FCtrlStraregy"].ToString() != "")
                {
                    model.FCtrlStraregy = int.Parse(row["FCtrlStraregy"].ToString());
                }
                if (row["FCtrlType"] != null && row["FCtrlType"].ToString() != "")
                {
                    model.FCtrlType = int.Parse(row["FCtrlType"].ToString());
                }
                if (row["FCUUnitID"] != null && row["FCUUnitID"].ToString() != "")
                {
                    model.FCUUnitID = int.Parse(row["FCUUnitID"].ToString());
                }
                if (row["FDailyConsume"] != null && row["FDailyConsume"].ToString() != "")
                {
                    model.FDailyConsume = decimal.Parse(row["FDailyConsume"].ToString());
                }
                if (row["FDefaultRoutingID"] != null && row["FDefaultRoutingID"].ToString() != "")
                {
                    model.FDefaultRoutingID = int.Parse(row["FDefaultRoutingID"].ToString());
                }
                if (row["FDefaultWorkTypeID"] != null && row["FDefaultWorkTypeID"].ToString() != "")
                {
                    model.FDefaultWorkTypeID = int.Parse(row["FDefaultWorkTypeID"].ToString());
                }
                if (row["FFixLeadTime"] != null && row["FFixLeadTime"].ToString() != "")
                {
                    model.FFixLeadTime = decimal.Parse(row["FFixLeadTime"].ToString());
                }
                if (row["FInHighLimit"] != null && row["FInHighLimit"].ToString() != "")
                {
                    model.FInHighLimit = decimal.Parse(row["FInHighLimit"].ToString());
                }
                if (row["FInLowLimit"] != null && row["FInLowLimit"].ToString() != "")
                {
                    model.FInLowLimit = decimal.Parse(row["FInLowLimit"].ToString());
                }
                if (row["FIsBackFlush"] != null && row["FIsBackFlush"].ToString() != "")
                {
                    model.FIsBackFlush = int.Parse(row["FIsBackFlush"].ToString());
                }
                if (row["FIsCharSourceItem"] != null && row["FIsCharSourceItem"].ToString() != "")
                {
                    model.FIsCharSourceItem = int.Parse(row["FIsCharSourceItem"].ToString());
                }
                if (row["FIsFixedReOrder"] != null && row["FIsFixedReOrder"].ToString() != "")
                {
                    if ((row["FIsFixedReOrder"].ToString() == "1") || (row["FIsFixedReOrder"].ToString().ToLower() == "true"))
                    {
                        model.FIsFixedReOrder = true;
                    }
                    else
                    {
                        model.FIsFixedReOrder = false;
                    }
                }
                if (row["FKanBanCapability"] != null && row["FKanBanCapability"].ToString() != "")
                {
                    model.FKanBanCapability = int.Parse(row["FKanBanCapability"].ToString());
                }
                if (row["FLeadTime"] != null && row["FLeadTime"].ToString() != "")
                {
                    model.FLeadTime = decimal.Parse(row["FLeadTime"].ToString());
                }
                if (row["FLowestBomCode"] != null && row["FLowestBomCode"].ToString() != "")
                {
                    model.FLowestBomCode = int.Parse(row["FLowestBomCode"].ToString());
                }
                if (row["FMRPCon"] != null && row["FMRPCon"].ToString() != "")
                {
                    if ((row["FMRPCon"].ToString() == "1") || (row["FMRPCon"].ToString().ToLower() == "true"))
                    {
                        model.FMRPCon = true;
                    }
                    else
                    {
                        model.FMRPCon = false;
                    }
                }
                if (row["FMRPOrder"] != null && row["FMRPOrder"].ToString() != "")
                {
                    if ((row["FMRPOrder"].ToString() == "1") || (row["FMRPOrder"].ToString().ToLower() == "true"))
                    {
                        model.FMRPOrder = true;
                    }
                    else
                    {
                        model.FMRPOrder = false;
                    }
                }
                if (row["FOrderInterVal"] != null && row["FOrderInterVal"].ToString() != "")
                {
                    model.FOrderInterVal = int.Parse(row["FOrderInterVal"].ToString());
                }
                if (row["FOrderPoint"] != null && row["FOrderPoint"].ToString() != "")
                {
                    model.FOrderPoint = decimal.Parse(row["FOrderPoint"].ToString());
                }
                if (row["FOrderTrategy"] != null && row["FOrderTrategy"].ToString() != "")
                {
                    model.FOrderTrategy = int.Parse(row["FOrderTrategy"].ToString());
                }
                if (row["FPlanMode"] != null && row["FPlanMode"].ToString() != "")
                {
                    model.FPlanMode = int.Parse(row["FPlanMode"].ToString());
                }
                if (row["FPlanner"] != null && row["FPlanner"].ToString() != "")
                {
                    model.FPlanner = int.Parse(row["FPlanner"].ToString());
                }
                if (row["FPlanPoint"] != null && row["FPlanPoint"].ToString() != "")
                {
                    model.FPlanPoint = int.Parse(row["FPlanPoint"].ToString());
                }
                if (row["FPlanTrategy"] != null && row["FPlanTrategy"].ToString() != "")
                {
                    model.FPlanTrategy = int.Parse(row["FPlanTrategy"].ToString());
                }
                if (row["FProductPrincipal"] != null && row["FProductPrincipal"].ToString() != "")
                {
                    model.FProductPrincipal = int.Parse(row["FProductPrincipal"].ToString());
                }
                if (row["FPutInteger"] != null && row["FPutInteger"].ToString() != "")
                {
                    if ((row["FPutInteger"].ToString() == "1") || (row["FPutInteger"].ToString().ToLower() == "true"))
                    {
                        model.FPutInteger = true;
                    }
                    else
                    {
                        model.FPutInteger = false;
                    }
                }
                if (row["FQtyMax"] != null && row["FQtyMax"].ToString() != "")
                {
                    model.FQtyMax = decimal.Parse(row["FQtyMax"].ToString());
                }
                if (row["FQtyMin"] != null && row["FQtyMin"].ToString() != "")
                {
                    model.FQtyMin = decimal.Parse(row["FQtyMin"].ToString());
                }
                if (row["FRequirePoint"] != null && row["FRequirePoint"].ToString() != "")
                {
                    model.FRequirePoint = int.Parse(row["FRequirePoint"].ToString());
                }
                if (row["FTotalTQQ"] != null && row["FTotalTQQ"].ToString() != "")
                {
                    model.FTotalTQQ = int.Parse(row["FTotalTQQ"].ToString());
                }
                if (row["F_101"] != null)
                {
                    model.F_101 = row["F_101"].ToString();
                }
                if (row["F_102"] != null)
                {
                    model.F_102 = row["F_102"].ToString();
                }
                if (row["F_103"] != null)
                {
                    model.F_103 = row["F_103"].ToString();
                }
                if (row["F_104"] != null)
                {
                    model.F_104 = row["F_104"].ToString();
                }
                if (row["F_105"] != null)
                {
                    model.F_105 = row["F_105"].ToString();
                }
                if (row["F_106"] != null)
                {
                    model.F_106 = row["F_106"].ToString();
                }
                if (row["F_107"] != null)
                {
                    model.F_107 = row["F_107"].ToString();
                }
                if (row["F_108"] != null)
                {
                    model.F_108 = row["F_108"].ToString();
                }
                if (row["F_109"] != null)
                {
                    model.F_109 = row["F_109"].ToString();
                }
                if (row["F_110"] != null)
                {
                    model.F_110 = row["F_110"].ToString();
                }
                if (row["FChartNumber"] != null)
                {
                    model.FChartNumber = row["FChartNumber"].ToString();
                }
                if (row["FCubicMeasure"] != null && row["FCubicMeasure"].ToString() != "")
                {
                    model.FCubicMeasure = int.Parse(row["FCubicMeasure"].ToString());
                }
                if (row["FGrossWeight"] != null && row["FGrossWeight"].ToString() != "")
                {
                    model.FGrossWeight = decimal.Parse(row["FGrossWeight"].ToString());
                }
                if (row["FHeight"] != null && row["FHeight"].ToString() != "")
                {
                    model.FHeight = decimal.Parse(row["FHeight"].ToString());
                }
                if (row["FIsFix"] != null && row["FIsFix"].ToString() != "")
                {
                    if ((row["FIsFix"].ToString() == "1") || (row["FIsFix"].ToString().ToLower() == "true"))
                    {
                        model.FIsFix = true;
                    }
                    else
                    {
                        model.FIsFix = false;
                    }
                }
                if (row["FIsKeyItem"] != null && row["FIsKeyItem"].ToString() != "")
                {
                    if ((row["FIsKeyItem"].ToString() == "1") || (row["FIsKeyItem"].ToString().ToLower() == "true"))
                    {
                        model.FIsKeyItem = true;
                    }
                    else
                    {
                        model.FIsKeyItem = false;
                    }
                }
                if (row["FLength"] != null && row["FLength"].ToString() != "")
                {
                    model.FLength = decimal.Parse(row["FLength"].ToString());
                }
                if (row["FMakeFile"] != null && row["FMakeFile"].ToString() != "")
                {
                    if ((row["FMakeFile"].ToString() == "1") || (row["FMakeFile"].ToString().ToLower() == "true"))
                    {
                        model.FMakeFile = true;
                    }
                    else
                    {
                        model.FMakeFile = false;
                    }
                }
                if (row["FMaund"] != null && row["FMaund"].ToString() != "")
                {
                    model.FMaund = int.Parse(row["FMaund"].ToString());
                }
                if (row["FNetWeight"] != null && row["FNetWeight"].ToString() != "")
                {
                    model.FNetWeight = decimal.Parse(row["FNetWeight"].ToString());
                }
                if (row["FSize"] != null && row["FSize"].ToString() != "")
                {
                    model.FSize = decimal.Parse(row["FSize"].ToString());
                }
                if (row["FStartService"] != null && row["FStartService"].ToString() != "")
                {
                    if ((row["FStartService"].ToString() == "1") || (row["FStartService"].ToString().ToLower() == "true"))
                    {
                        model.FStartService = true;
                    }
                    else
                    {
                        model.FStartService = false;
                    }
                }
                if (row["FTtermOfService"] != null && row["FTtermOfService"].ToString() != "")
                {
                    model.FTtermOfService = int.Parse(row["FTtermOfService"].ToString());
                }
                if (row["FTtermOfUsefulTime"] != null && row["FTtermOfUsefulTime"].ToString() != "")
                {
                    model.FTtermOfUsefulTime = int.Parse(row["FTtermOfUsefulTime"].ToString());
                }
                if (row["FVersion"] != null)
                {
                    model.FVersion = row["FVersion"].ToString();
                }
                if (row["FWidth"] != null && row["FWidth"].ToString() != "")
                {
                    model.FWidth = decimal.Parse(row["FWidth"].ToString());
                }
                if (row["FCAVAcctID"] != null && row["FCAVAcctID"].ToString() != "")
                {
                    model.FCAVAcctID = int.Parse(row["FCAVAcctID"].ToString());
                }
                if (row["FCBAppendProject"] != null && row["FCBAppendProject"].ToString() != "")
                {
                    model.FCBAppendProject = int.Parse(row["FCBAppendProject"].ToString());
                }
                if (row["FCBAppendRate"] != null && row["FCBAppendRate"].ToString() != "")
                {
                    model.FCBAppendRate = decimal.Parse(row["FCBAppendRate"].ToString());
                }
                if (row["FCBRouting"] != null && row["FCBRouting"].ToString() != "")
                {
                    model.FCBRouting = int.Parse(row["FCBRouting"].ToString());
                }
                if (row["FChgFeeRate"] != null && row["FChgFeeRate"].ToString() != "")
                {
                    model.FChgFeeRate = decimal.Parse(row["FChgFeeRate"].ToString());
                }
                if (row["FCostBomID"] != null && row["FCostBomID"].ToString() != "")
                {
                    model.FCostBomID = int.Parse(row["FCostBomID"].ToString());
                }
                if (row["FMCVAcctID"] != null && row["FMCVAcctID"].ToString() != "")
                {
                    model.FMCVAcctID = int.Parse(row["FMCVAcctID"].ToString());
                }
                if (row["FOutMachFee"] != null && row["FOutMachFee"].ToString() != "")
                {
                    model.FOutMachFee = decimal.Parse(row["FOutMachFee"].ToString());
                }
                if (row["FOutMachFeeProject"] != null && row["FOutMachFeeProject"].ToString() != "")
                {
                    model.FOutMachFeeProject = int.Parse(row["FOutMachFeeProject"].ToString());
                }
                if (row["FPCVAcctID"] != null && row["FPCVAcctID"].ToString() != "")
                {
                    model.FPCVAcctID = int.Parse(row["FPCVAcctID"].ToString());
                }
                if (row["FPieceRate"] != null && row["FPieceRate"].ToString() != "")
                {
                    model.FPieceRate = decimal.Parse(row["FPieceRate"].ToString());
                }
                if (row["FPIVAcctID"] != null && row["FPIVAcctID"].ToString() != "")
                {
                    model.FPIVAcctID = int.Parse(row["FPIVAcctID"].ToString());
                }
                if (row["FPOVAcctID"] != null && row["FPOVAcctID"].ToString() != "")
                {
                    model.FPOVAcctID = int.Parse(row["FPOVAcctID"].ToString());
                }
                if (row["FSLAcctID"] != null && row["FSLAcctID"].ToString() != "")
                {
                    model.FSLAcctID = int.Parse(row["FSLAcctID"].ToString());
                }
                if (row["FStandardCost"] != null && row["FStandardCost"].ToString() != "")
                {
                    model.FStandardCost = decimal.Parse(row["FStandardCost"].ToString());
                }
                if (row["FStandardManHour"] != null && row["FStandardManHour"].ToString() != "")
                {
                    model.FStandardManHour = decimal.Parse(row["FStandardManHour"].ToString());
                }
                if (row["FStdBatchQty"] != null && row["FStdBatchQty"].ToString() != "")
                {
                    model.FStdBatchQty = decimal.Parse(row["FStdBatchQty"].ToString());
                }
                if (row["FStdFixFeeRate"] != null && row["FStdFixFeeRate"].ToString() != "")
                {
                    model.FStdFixFeeRate = decimal.Parse(row["FStdFixFeeRate"].ToString());
                }
                if (row["FStdPayRate"] != null && row["FStdPayRate"].ToString() != "")
                {
                    model.FStdPayRate = decimal.Parse(row["FStdPayRate"].ToString());
                }
                if (row["FIdentifier"] != null && row["FIdentifier"].ToString() != "")
                {
                    model.FIdentifier = int.Parse(row["FIdentifier"].ToString());
                }
                if (row["FInspectionLevel"] != null && row["FInspectionLevel"].ToString() != "")
                {
                    model.FInspectionLevel = int.Parse(row["FInspectionLevel"].ToString());
                }
                if (row["FInspectionProject"] != null && row["FInspectionProject"].ToString() != "")
                {
                    model.FInspectionProject = int.Parse(row["FInspectionProject"].ToString());
                }
                if (row["FIsListControl"] != null && row["FIsListControl"].ToString() != "")
                {
                    model.FIsListControl = int.Parse(row["FIsListControl"].ToString());
                }
                if (row["FOtherChkMde"] != null && row["FOtherChkMde"].ToString() != "")
                {
                    model.FOtherChkMde = int.Parse(row["FOtherChkMde"].ToString());
                }
                if (row["FProChkMde"] != null && row["FProChkMde"].ToString() != "")
                {
                    model.FProChkMde = int.Parse(row["FProChkMde"].ToString());
                }
                if (row["FSampStdCritical"] != null)
                {
                    model.FSampStdCritical = row["FSampStdCritical"].ToString();
                }
                if (row["FSampStdSlight"] != null)
                {
                    model.FSampStdSlight = row["FSampStdSlight"].ToString();
                }
                if (row["FSampStdStrict"] != null)
                {
                    model.FSampStdStrict = row["FSampStdStrict"].ToString();
                }
                if (row["FSOChkMde"] != null && row["FSOChkMde"].ToString() != "")
                {
                    model.FSOChkMde = int.Parse(row["FSOChkMde"].ToString());
                }
                if (row["FStkChkAlrm"] != null && row["FStkChkAlrm"].ToString() != "")
                {
                    model.FStkChkAlrm = int.Parse(row["FStkChkAlrm"].ToString());
                }
                if (row["FStkChkMde"] != null && row["FStkChkMde"].ToString() != "")
                {
                    model.FStkChkMde = int.Parse(row["FStkChkMde"].ToString());
                }
                if (row["FStkChkPrd"] != null && row["FStkChkPrd"].ToString() != "")
                {
                    model.FStkChkPrd = int.Parse(row["FStkChkPrd"].ToString());
                }
                if (row["FWthDrwChkMde"] != null && row["FWthDrwChkMde"].ToString() != "")
                {
                    model.FWthDrwChkMde = int.Parse(row["FWthDrwChkMde"].ToString());
                }
                if (row["FWWChkMde"] != null && row["FWWChkMde"].ToString() != "")
                {
                    model.FWWChkMde = int.Parse(row["FWWChkMde"].ToString());
                }
                if (row["FConsumeTaxRate"] != null && row["FConsumeTaxRate"].ToString() != "")
                {
                    model.FConsumeTaxRate = decimal.Parse(row["FConsumeTaxRate"].ToString());
                }
                if (row["FCubageDecimal"] != null && row["FCubageDecimal"].ToString() != "")
                {
                    model.FCubageDecimal = int.Parse(row["FCubageDecimal"].ToString());
                }
                if (row["FExportRate"] != null && row["FExportRate"].ToString() != "")
                {
                    model.FExportRate = decimal.Parse(row["FExportRate"].ToString());
                }
                if (row["FFirstUnit"] != null)
                {
                    model.FFirstUnit = row["FFirstUnit"].ToString();
                }
                if (row["FFirstUnitRate"] != null && row["FFirstUnitRate"].ToString() != "")
                {
                    model.FFirstUnitRate = decimal.Parse(row["FFirstUnitRate"].ToString());
                }
                if (row["FHSNumber"] != null && row["FHSNumber"].ToString() != "")
                {
                    model.FHSNumber = int.Parse(row["FHSNumber"].ToString());
                }
                if (row["FImpostTaxRate"] != null && row["FImpostTaxRate"].ToString() != "")
                {
                    model.FImpostTaxRate = decimal.Parse(row["FImpostTaxRate"].ToString());
                }
                if (row["FIsManage"] != null && row["FIsManage"].ToString() != "")
                {
                    if ((row["FIsManage"].ToString() == "1") || (row["FIsManage"].ToString().ToLower() == "true"))
                    {
                        model.FIsManage = true;
                    }
                    else
                    {
                        model.FIsManage = false;
                    }
                }
                if (row["FLenDecimal"] != null && row["FLenDecimal"].ToString() != "")
                {
                    model.FLenDecimal = int.Parse(row["FLenDecimal"].ToString());
                }
                if (row["FManageType"] != null && row["FManageType"].ToString() != "")
                {
                    model.FManageType = int.Parse(row["FManageType"].ToString());
                }
                if (row["FModelEn"] != null)
                {
                    model.FModelEn = row["FModelEn"].ToString();
                }
                if (row["FNameEn"] != null)
                {
                    model.FNameEn = row["FNameEn"].ToString();
                }
                if (row["FPackType"] != null && row["FPackType"].ToString() != "")
                {
                    model.FPackType = int.Parse(row["FPackType"].ToString());
                }
                if (row["FSecondUnit"] != null)
                {
                    model.FSecondUnit = row["FSecondUnit"].ToString();
                }
                if (row["FSecondUnitRate"] != null && row["FSecondUnitRate"].ToString() != "")
                {
                    model.FSecondUnitRate = decimal.Parse(row["FSecondUnitRate"].ToString());
                }
                if (row["FWeightDecimal"] != null && row["FWeightDecimal"].ToString() != "")
                {
                    model.FWeightDecimal = int.Parse(row["FWeightDecimal"].ToString());
                }
            }
            return model;
        }
    }
    #endregion

    #region PoInStock
    public partial class PoInStock
    {
        /// <summary>
        /// 插入收料通知主表
        /// </summary>
        /// <param name="fInterID">外键列</param>
        /// <param name="fBillNo">收料通知单号</param>
        /// <param name="fDate">单据日期</param>
        /// <param name="fHeadSelfP0341">alcon 单号</param>
        /// <returns></returns>
        public bool InsertPoInStock(int fInterID, string fBillNo, DateTime fDate, string fHeadSelfP0341)
        {
            bool retVal = false;
            HuaLiQin.DAL.PoInStock dalPoInStock = new PoInStock();
            HuaLiQin.Model.POInStock model = new POInStock();
            model.FBrNo = "0";
            model.FInterID = fInterID;
            model.FBillNo = fBillNo;
            model.FCnnBillNo = "";
            model.FNote = "";
            model.FCreateDate = DateTime.Now;

            model.FCurrencyID = 1;
            //model.FTranType = 72;
            model.FTranType = 72;
            //model.FSupplyID = 14063;
            model.FSupplyID = 8255;
            //model.FDeptID = 7450;
            model.FDeptID = 266;
            //model.FEmpID = 900;
            model.FEmpID = 273;
            model.FDate = fDate;
            //model.FBillerID = 16411;
            model.FBillerID = 16443;//吴文静1
            model.FFManagerID = 0;
            model.FClosed = 0;
            model.FInvoiceClosed = 0;
            model.FBClosed = 0;
            model.FExchangeRate = 1;
            model.FStatus = 0;
            model.FUpStockWhenSave = true;
            //model.FPOStyle = 252;
            model.FPOStyle = 252;
            model.FRelateBrID = 0;
            model.FSelTranType = 0;
            model.FChildren = 0;
            model.FAreaPS = 20302;
            model.FManageType = 0;
            //model.FBizType = 12510;
            model.FBizType = 12510;
            model.FWWType = 0;
            model.FExchangeRateType = 1;
            //model.FPOMode = 36680;
            model.FPOMode = 36680;
            model.FAccessoryCount = 0;
            model.FPrintCount = 0;
            model.FIsCheck = 0;
            model.FHeadSelfP0341 = fHeadSelfP0341;

            if (dalPoInStock.Add(model) == true)
            {
                retVal = true;
            }

            return retVal;
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(POInStock model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into POInStock(");
            strSql.Append("FBrNo,FInterID,FBillNo,FCurrencyID,FTranType,FSupplyID,FDeptID,FEmpID,FDate,FBillerID,FClosed,FInvoiceClosed,FBClosed,FExchangeRate,FStatus,FCancellation,FUpStockWhenSave,FPOStyle,FSelectBillNo,FSelTranType,FChildren,FTranStatus,FAreaPS,FReStatus,FManageType,FBizType,FWWType,FExchangeRateType,FAccessoryCount,FPOMode,FPrintCount,FIsCheck,FHeadSelfP0341)");
            strSql.Append(" values (");
            strSql.Append("@FBrNo,@FInterID,@FBillNo,@FCurrencyID,@FTranType,@FSupplyID,@FDeptID,@FEmpID,@FDate,@FBillerID,@FClosed,@FInvoiceClosed,@FBClosed,@FExchangeRate,@FStatus,@FCancellation,@FUpStockWhenSave,@FPOStyle,@FSelectBillNo,@FSelTranType,@FChildren,@FTranStatus,@FAreaPS,@FReStatus,@FManageType,@FBizType,@FWWType,@FExchangeRateType,@FAccessoryCount,@FPOMode,@FPrintCount,@FIsCheck,@FHeadSelfP0341)");
            SqlParameter[] parameters = {
					new SqlParameter("@FBrNo", SqlDbType.VarChar,10),
					new SqlParameter("@FInterID", SqlDbType.Int,4),
					new SqlParameter("@FBillNo", SqlDbType.NVarChar,255),
					new SqlParameter("@FCurrencyID", SqlDbType.Int,4),
					new SqlParameter("@FTranType", SqlDbType.SmallInt,2),
					new SqlParameter("@FSupplyID", SqlDbType.Int,4),
					new SqlParameter("@FDeptID", SqlDbType.Int,4),
					new SqlParameter("@FEmpID", SqlDbType.Int,4),
					new SqlParameter("@FDate", SqlDbType.DateTime),
					new SqlParameter("@FBillerID", SqlDbType.Int,4),
					new SqlParameter("@FClosed", SqlDbType.SmallInt,2),
					new SqlParameter("@FInvoiceClosed", SqlDbType.SmallInt,2),
					new SqlParameter("@FBClosed", SqlDbType.SmallInt,2),
					new SqlParameter("@FExchangeRate", SqlDbType.Float,8),
					new SqlParameter("@FStatus", SqlDbType.SmallInt,2),
					new SqlParameter("@FCancellation", SqlDbType.Bit,1),
					new SqlParameter("@FUpStockWhenSave", SqlDbType.Bit,1),
					new SqlParameter("@FPOStyle", SqlDbType.Int,4),
					new SqlParameter("@FSelectBillNo", SqlDbType.NVarChar,255),
					new SqlParameter("@FSelTranType", SqlDbType.Int,4),
					new SqlParameter("@FChildren", SqlDbType.Int,4),
					new SqlParameter("@FTranStatus", SqlDbType.Int,4),
					new SqlParameter("@FAreaPS", SqlDbType.Int,4),
					new SqlParameter("@FReStatus", SqlDbType.NVarChar,50),
					new SqlParameter("@FManageType", SqlDbType.Int,4),
					new SqlParameter("@FBizType", SqlDbType.Int,4),
					new SqlParameter("@FWWType", SqlDbType.Int,4),
					new SqlParameter("@FExchangeRateType", SqlDbType.Int,4),
					new SqlParameter("@FAccessoryCount", SqlDbType.Int,4),
					new SqlParameter("@FPOMode", SqlDbType.Int,4),
					new SqlParameter("@FPrintCount", SqlDbType.Int,4),
					new SqlParameter("@FIsCheck", SqlDbType.Int,4),
					new SqlParameter("@FHeadSelfP0341", SqlDbType.VarChar,255)};
            parameters[0].Value = model.FBrNo;
            parameters[1].Value = model.FInterID;
            parameters[2].Value = model.FBillNo;
            parameters[3].Value = model.FCurrencyID;
            parameters[4].Value = model.FTranType;
            parameters[5].Value = model.FSupplyID;
            parameters[6].Value = model.FDeptID;
            parameters[7].Value = model.FEmpID;
            parameters[8].Value = model.FDate;
            parameters[9].Value = model.FBillerID;
            parameters[10].Value = model.FClosed;
            parameters[11].Value = model.FInvoiceClosed;
            parameters[12].Value = model.FBClosed;
            parameters[13].Value = model.FExchangeRate;
            parameters[14].Value = model.FStatus;
            parameters[15].Value = model.FCancellation;
            parameters[16].Value = model.FUpStockWhenSave;
            parameters[17].Value = model.FPOStyle;
            parameters[18].Value = model.FSelectBillNo;
            parameters[19].Value = model.FSelTranType;
            parameters[20].Value = model.FChildren;
            parameters[21].Value = model.FTranStatus;
            parameters[22].Value = model.FAreaPS;
            parameters[23].Value = model.FReStatus;
            parameters[24].Value = model.FManageType;
            parameters[25].Value = model.FBizType;
            parameters[26].Value = model.FWWType;
            parameters[27].Value = model.FExchangeRateType;
            parameters[28].Value = model.FAccessoryCount;
            parameters[29].Value = model.FPOMode;
            parameters[30].Value = model.FPrintCount;
            parameters[31].Value = model.FIsCheck;
            parameters[32].Value = model.FHeadSelfP0341;

            int rows = SqlHelper.ExecuteSql(strSql.ToString(), parameters);
            return rows > 0 ? true : false;
        }

        /// <summary>
        /// 取得最大收料单单据编号
        /// 单据类型,这里主要区分是不是导入，导入的数据单据以DR开头
        /// </summary>
        /// <returns></returns>
        public string GetMaxFBillNo()
        {
            object retVal = SqlHelper.ExecuteScalar("SELECT MAX(FBillNo) FROM POInStock WHERE FBillNo LIKE 'DA%'", null);
            return retVal != null ? retVal.ToString() : "";
        }

        /// <summary>
        /// 取得最大单据编号
        /// </summary>
        /// <param name="sBillType">单据类型,这里主要区分是不是导入，导入的数据单据以DR开头</param>
        /// <returns></returns>
        public string GetMaxFInterID()
        {
            int retVal = SqlHelper.ExecuteNonQuery("UPDATE ICMaxNum SET FMaxNum = FMaxNum + 1 WHERE FTableName = 'poinstock'", null);
            if (retVal > 0)
            {
                object temp = SqlHelper.ExecuteScalar("SELECT FMaxNum FROM ICMaxNum WHERE FTableName = 'poinstock'", null);

                return temp != null ? temp.ToString() : "";
            }
            else
            {
                return "";
            }
        }
    }


    #endregion
    
    #region PoInStockEntry
    public partial class PoInStockEntry
    {
        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(POInStockEntry model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into POInStockEntry(");
            strSql.Append("FBrNo,FInterID,FEntryID,FItemID,FQty,FCommitQty,FPrice,FAmount,FNote,FInvoiceQty,FBCommitQty,FQCheckQty,FAuxQCheckQty,FUnitID,FAuxBCommitQty,FAuxCommitQty,FAuxInvoiceQty,FAuxPrice,FAuxQty,FSourceEntryID,FQtyPass,FAuxQtyPass,FMapNumber,FMapName,FBatchNo,FKFDate,FKFPeriod,FDCSPID,FAuxPropID,FDCStockID,FSecCoefficient,FSecQty,FSecCommitQty,FSourceTranType,FSourceInterId,FSourceBillNo,FContractInterID,FContractEntryID,FContractBillNo,FOrderInterID,FOrderEntryID,FOrderBillNo,FStockID,FPeriodDate,FNotPassQty,FNPCommitQty,FSampleBreakQty,FConPassQty,FConCommitQty,FAuxNotPassQty,FAuxNPCommitQty,FAuxSampleBreakQty,FAuxConPassQty,FAuxConCommitQty,FAuxRelateQty,FRelateQty,FBackQty,FAuxBackQty,FSecBackQty,FSecConCommitQty,FPlanMode,FMTONo,FOrderType,FEntryAccessoryCount,FDeliveryNoticeEntryID,FDeliveryNoticeFID,FDischarged,FCheckMethod,FScrapQty,FAuxScrapQty,FSecScrapQty,FSecConCommiqty,FScrapInCommitQty,FAuxScrapInCommitQty,FSecScrapInCommitQty,FSecQtyPass,FSecConPassQty,FSecNotPassQty,FSecSampleBreakQty,FSecRelateQty,FSecQCheckQty,FBackType,FTime,FSampleConclusion,FSamBillNo,FSamInterID,FSamEntryID,FEntrySelfP0386)");
            strSql.Append(" values (");
            strSql.Append("@FBrNo,@FInterID,@FEntryID,@FItemID,@FQty,@FCommitQty,@FPrice,@FAmount,@FNote,@FInvoiceQty,@FBCommitQty,@FQCheckQty,@FAuxQCheckQty,@FUnitID,@FAuxBCommitQty,@FAuxCommitQty,@FAuxInvoiceQty,@FAuxPrice,@FAuxQty,@FSourceEntryID,@FQtyPass,@FAuxQtyPass,@FMapNumber,@FMapName,@FBatchNo,@FKFDate,@FKFPeriod,@FDCSPID,@FAuxPropID,@FDCStockID,@FSecCoefficient,@FSecQty,@FSecCommitQty,@FSourceTranType,@FSourceInterId,@FSourceBillNo,@FContractInterID,@FContractEntryID,@FContractBillNo,@FOrderInterID,@FOrderEntryID,@FOrderBillNo,@FStockID,@FPeriodDate,@FNotPassQty,@FNPCommitQty,@FSampleBreakQty,@FConPassQty,@FConCommitQty,@FAuxNotPassQty,@FAuxNPCommitQty,@FAuxSampleBreakQty,@FAuxConPassQty,@FAuxConCommitQty,@FAuxRelateQty,@FRelateQty,@FBackQty,@FAuxBackQty,@FSecBackQty,@FSecConCommitQty,@FPlanMode,@FMTONo,@FOrderType,@FEntryAccessoryCount,@FDeliveryNoticeEntryID,@FDeliveryNoticeFID,@FDischarged,@FCheckMethod,@FScrapQty,@FAuxScrapQty,@FSecScrapQty,@FSecConCommiqty,@FScrapInCommitQty,@FAuxScrapInCommitQty,@FSecScrapInCommitQty,@FSecQtyPass,@FSecConPassQty,@FSecNotPassQty,@FSecSampleBreakQty,@FSecRelateQty,@FSecQCheckQty,@FBackType,@FTime,@FSampleConclusion,@FSamBillNo,@FSamInterID,@FSamEntryID,@FEntrySelfP0386)");
            strSql.Append(";select @@IDENTITY");
            SqlParameter[] parameters = {
					new SqlParameter("@FBrNo", SqlDbType.VarChar,10),
					new SqlParameter("@FInterID", SqlDbType.Int,4),
					new SqlParameter("@FEntryID", SqlDbType.Int,4),
					new SqlParameter("@FItemID", SqlDbType.Int,4),
					new SqlParameter("@FQty", SqlDbType.Decimal,13),
					new SqlParameter("@FCommitQty", SqlDbType.Decimal,13),
					new SqlParameter("@FPrice", SqlDbType.Decimal,13),
					new SqlParameter("@FAmount", SqlDbType.Decimal,13),
					new SqlParameter("@FNote", SqlDbType.Char,255),
					new SqlParameter("@FInvoiceQty", SqlDbType.Decimal,13),
					new SqlParameter("@FBCommitQty", SqlDbType.Decimal,13),
					new SqlParameter("@FQCheckQty", SqlDbType.Decimal,13),
					new SqlParameter("@FAuxQCheckQty", SqlDbType.Decimal,13),
					new SqlParameter("@FUnitID", SqlDbType.Int,4),
					new SqlParameter("@FAuxBCommitQty", SqlDbType.Decimal,13),
					new SqlParameter("@FAuxCommitQty", SqlDbType.Decimal,13),
					new SqlParameter("@FAuxInvoiceQty", SqlDbType.Decimal,13),
					new SqlParameter("@FAuxPrice", SqlDbType.Decimal,13),
					new SqlParameter("@FAuxQty", SqlDbType.Decimal,13),
					new SqlParameter("@FSourceEntryID", SqlDbType.Int,4),
					new SqlParameter("@FQtyPass", SqlDbType.Decimal,13),
					new SqlParameter("@FAuxQtyPass", SqlDbType.Decimal,13),
					new SqlParameter("@FMapNumber", SqlDbType.VarChar,80),
					new SqlParameter("@FMapName", SqlDbType.NVarChar,256),
					new SqlParameter("@FBatchNo", SqlDbType.VarChar,200),
					new SqlParameter("@FKFDate", SqlDbType.DateTime),
					new SqlParameter("@FKFPeriod", SqlDbType.Int,4),
					new SqlParameter("@FDCSPID", SqlDbType.Int,4),
					new SqlParameter("@FAuxPropID", SqlDbType.Int,4),
					new SqlParameter("@FDCStockID", SqlDbType.Int,4),
					new SqlParameter("@FSecCoefficient", SqlDbType.Decimal,13),
					new SqlParameter("@FSecQty", SqlDbType.Decimal,13),
					new SqlParameter("@FSecCommitQty", SqlDbType.Decimal,13),
					new SqlParameter("@FSourceTranType", SqlDbType.Int,4),
					new SqlParameter("@FSourceInterId", SqlDbType.Int,4),
					new SqlParameter("@FSourceBillNo", SqlDbType.NVarChar,255),
					new SqlParameter("@FContractInterID", SqlDbType.Int,4),
					new SqlParameter("@FContractEntryID", SqlDbType.Int,4),
					new SqlParameter("@FContractBillNo", SqlDbType.NVarChar,255),
					new SqlParameter("@FOrderInterID", SqlDbType.Int,4),
					new SqlParameter("@FOrderEntryID", SqlDbType.Int,4),
					new SqlParameter("@FOrderBillNo", SqlDbType.NVarChar,255),
					new SqlParameter("@FStockID", SqlDbType.Int,4),
					new SqlParameter("@FPeriodDate", SqlDbType.DateTime),
					new SqlParameter("@FNotPassQty", SqlDbType.Decimal,13),
					new SqlParameter("@FNPCommitQty", SqlDbType.Decimal,13),
					new SqlParameter("@FSampleBreakQty", SqlDbType.Decimal,13),
					new SqlParameter("@FConPassQty", SqlDbType.Decimal,13),
					new SqlParameter("@FConCommitQty", SqlDbType.Decimal,13),
					new SqlParameter("@FAuxNotPassQty", SqlDbType.Decimal,13),
					new SqlParameter("@FAuxNPCommitQty", SqlDbType.Decimal,13),
					new SqlParameter("@FAuxSampleBreakQty", SqlDbType.Decimal,13),
					new SqlParameter("@FAuxConPassQty", SqlDbType.Decimal,13),
					new SqlParameter("@FAuxConCommitQty", SqlDbType.Decimal,13),
					new SqlParameter("@FAuxRelateQty", SqlDbType.Decimal,13),
					new SqlParameter("@FRelateQty", SqlDbType.Decimal,13),
					new SqlParameter("@FBackQty", SqlDbType.Decimal,13),
					new SqlParameter("@FAuxBackQty", SqlDbType.Decimal,13),
					new SqlParameter("@FSecBackQty", SqlDbType.Decimal,13),
					new SqlParameter("@FSecConCommitQty", SqlDbType.Decimal,13),
					new SqlParameter("@FPlanMode", SqlDbType.Int,4),
					new SqlParameter("@FMTONo", SqlDbType.NVarChar,50),
					new SqlParameter("@FOrderType", SqlDbType.Int,4),
					new SqlParameter("@FEntryAccessoryCount", SqlDbType.Int,4),
					new SqlParameter("@FDeliveryNoticeEntryID", SqlDbType.Int,4),
					new SqlParameter("@FDeliveryNoticeFID", SqlDbType.Int,4),
					new SqlParameter("@FDischarged", SqlDbType.Int,4),
					new SqlParameter("@FCheckMethod", SqlDbType.Int,4),
					new SqlParameter("@FScrapQty", SqlDbType.Decimal,13),
					new SqlParameter("@FAuxScrapQty", SqlDbType.Decimal,13),
					new SqlParameter("@FSecScrapQty", SqlDbType.Decimal,13),
					new SqlParameter("@FSecConCommiqty", SqlDbType.Decimal,13),
					new SqlParameter("@FScrapInCommitQty", SqlDbType.Decimal,13),
					new SqlParameter("@FAuxScrapInCommitQty", SqlDbType.Decimal,13),
					new SqlParameter("@FSecScrapInCommitQty", SqlDbType.Decimal,13),
					new SqlParameter("@FSecQtyPass", SqlDbType.Decimal,13),
					new SqlParameter("@FSecConPassQty", SqlDbType.Decimal,13),
					new SqlParameter("@FSecNotPassQty", SqlDbType.Decimal,13),
					new SqlParameter("@FSecSampleBreakQty", SqlDbType.Decimal,13),
					new SqlParameter("@FSecRelateQty", SqlDbType.Decimal,13),
					new SqlParameter("@FSecQCheckQty", SqlDbType.Decimal,13),
					new SqlParameter("@FBackType", SqlDbType.Int,4),
					new SqlParameter("@FTime", SqlDbType.Int,4),
					new SqlParameter("@FSampleConclusion", SqlDbType.Int,4),
					new SqlParameter("@FSamBillNo", SqlDbType.NVarChar,255),
					new SqlParameter("@FSamInterID", SqlDbType.Int,4),
					new SqlParameter("@FSamEntryID", SqlDbType.Int,4),
					new SqlParameter("@FEntrySelfP0386", SqlDbType.VarChar,255)};
            parameters[0].Value = model.FBrNo;
            parameters[1].Value = model.FInterID;
            parameters[2].Value = model.FEntryID;
            parameters[3].Value = model.FItemID;
            parameters[4].Value = model.FQty;
            parameters[5].Value = model.FCommitQty;
            parameters[6].Value = model.FPrice;
            parameters[7].Value = model.FAmount;
            parameters[8].Value = model.FNote;
            parameters[9].Value = model.FInvoiceQty;
            parameters[10].Value = model.FBCommitQty;
            parameters[11].Value = model.FQCheckQty;
            parameters[12].Value = model.FAuxQCheckQty;
            parameters[13].Value = model.FUnitID;
            parameters[14].Value = model.FAuxBCommitQty;
            parameters[15].Value = model.FAuxCommitQty;
            parameters[16].Value = model.FAuxInvoiceQty;
            parameters[17].Value = model.FAuxPrice;
            parameters[18].Value = model.FAuxQty;
            parameters[19].Value = model.FSourceEntryID;
            parameters[20].Value = model.FQtyPass;
            parameters[21].Value = model.FAuxQtyPass;
            parameters[22].Value = model.FMapNumber;
            parameters[23].Value = model.FMapName;
            parameters[24].Value = model.FBatchNo;
            parameters[25].Value = model.FKFDate;
            parameters[26].Value = model.FKFPeriod;
            parameters[27].Value = model.FDCSPID;
            parameters[28].Value = model.FAuxPropID;
            parameters[29].Value = model.FDCStockID;
            parameters[30].Value = model.FSecCoefficient;
            parameters[31].Value = model.FSecQty;
            parameters[32].Value = model.FSecCommitQty;
            parameters[33].Value = model.FSourceTranType;
            parameters[34].Value = model.FSourceInterId;
            parameters[35].Value = model.FSourceBillNo;
            parameters[36].Value = model.FContractInterID;
            parameters[37].Value = model.FContractEntryID;
            parameters[38].Value = model.FContractBillNo;
            parameters[39].Value = model.FOrderInterID;
            parameters[40].Value = model.FOrderEntryID;
            parameters[41].Value = model.FOrderBillNo;
            parameters[42].Value = model.FStockID;
            parameters[43].Value = model.FPeriodDate;
            parameters[44].Value = model.FNotPassQty;
            parameters[45].Value = model.FNPCommitQty;
            parameters[46].Value = model.FSampleBreakQty;
            parameters[47].Value = model.FConPassQty;
            parameters[48].Value = model.FConCommitQty;
            parameters[49].Value = model.FAuxNotPassQty;
            parameters[50].Value = model.FAuxNPCommitQty;
            parameters[51].Value = model.FAuxSampleBreakQty;
            parameters[52].Value = model.FAuxConPassQty;
            parameters[53].Value = model.FAuxConCommitQty;
            parameters[54].Value = model.FAuxRelateQty;
            parameters[55].Value = model.FRelateQty;
            parameters[56].Value = model.FBackQty;
            parameters[57].Value = model.FAuxBackQty;
            parameters[58].Value = model.FSecBackQty;
            parameters[59].Value = model.FSecConCommitQty;
            parameters[60].Value = model.FPlanMode;
            parameters[61].Value = model.FMTONo;
            parameters[62].Value = model.FOrderType;
            parameters[63].Value = model.FEntryAccessoryCount;
            parameters[64].Value = model.FDeliveryNoticeEntryID;
            parameters[65].Value = model.FDeliveryNoticeFID;
            parameters[66].Value = model.FDischarged;
            parameters[67].Value = model.FCheckMethod;
            parameters[68].Value = model.FScrapQty;
            parameters[69].Value = model.FAuxScrapQty;
            parameters[70].Value = model.FSecScrapQty;
            parameters[71].Value = model.FSecConCommiqty;
            parameters[72].Value = model.FScrapInCommitQty;
            parameters[73].Value = model.FAuxScrapInCommitQty;
            parameters[74].Value = model.FSecScrapInCommitQty;
            parameters[75].Value = model.FSecQtyPass;
            parameters[76].Value = model.FSecConPassQty;
            parameters[77].Value = model.FSecNotPassQty;
            parameters[78].Value = model.FSecSampleBreakQty;
            parameters[79].Value = model.FSecRelateQty;
            parameters[80].Value = model.FSecQCheckQty;
            parameters[81].Value = model.FBackType;
            parameters[82].Value = model.FTime;
            parameters[83].Value = model.FSampleConclusion;
            parameters[84].Value = model.FSamBillNo;
            parameters[85].Value = model.FSamInterID;
            parameters[86].Value = model.FSamEntryID;
            parameters[87].Value = model.FEntrySelfP0386;

            //object obj = SqlHelper.ExecuteNonQuery(strSql.ToString(), parameters);
            //if (string.IsNullOrEmpty(""))//obj.ToString()))
            //{
            //    return false;
            //}
            //else
            //{
            //    return true;
            //}
            int retVal = SqlHelper.ExecuteNonQuery(strSql.ToString(), parameters);
            return retVal > 0 ? true : false;
        }

        /// <summary>
        /// 插入收料通知明细表
        /// </summary>
        /// <param name="fInterID">外键</param>
        /// <param name="fEntryID">收料单行号</param>
        /// <param name="fItemID">产品编号</param>
        /// <param name="fQty">数量</param>
        /// <param name="fPrice">单价</param>
        /// <param name="fAmount">金额</param>
        /// <param name="fUnitID">单位</param>
        /// <param name="fAuxPrice">输入价格</param>
        /// <param name="fAuxQty">输入数量</param>
        /// <param name="fKFDate">生产日期</param>
        /// <param name="fKFPeriod">有效期（天）</param>
        /// <param name="fStockID">仓库</param>
        /// <param name="fPeriodDate">失效时间</param>
        /// <param name="fEntrySelfP0386">alcon行号</param>
        /// <param name="fQtyPass">合格数量</param>
        /// <param name="fAuxQtyPass">输入合格数量</param>
        /// <param name="fBatchNo">批号</param>
        /// <param name="fDCSPID">库位</param>
        /// <param name="fAuxPropID">注册证号</param>
        /// <returns></returns>
        public bool InsertPoInStockEntry(
            int fInterID,
            int fEntryID,
            int fItemID,
            decimal fQty,
            decimal fPrice,
            decimal fAmount,
            int fUnitID,
            decimal fAuxPrice,
            decimal fAuxQty,
            DateTime fKFDate,
            int fKFPeriod,
            int fStockID,//Default:7464
            DateTime fPeriodDate,
            string fEntrySelfP0386,
            decimal fQtyPass,
            decimal fAuxQtyPass,
            string fBatchNo,
            int fDCSPID,
            int fAuxPropID)
        {
            bool retVal = false;

            HuaLiQin.DAL.PoInStockEntry dalPOInStockEntry = new HuaLiQin.DAL.PoInStockEntry();
            HuaLiQin.Model.POInStockEntry model = new Model.POInStockEntry();

            model.FBrNo = "0";
            //
            model.FInterID = fInterID;
            //
            model.FEntryID = fEntryID;
            //
            model.FItemID = fItemID;
            //
            model.FQty = fQty;
            model.FCommitQty = 0;
            //
            model.FPrice = fPrice;
            //
            model.FAmount = fAmount;
            model.FNote = "";
            model.FInvoiceQty = 0;
            model.FBCommitQty = 0;
            model.FQCheckQty = 0;
            model.FAuxQCheckQty = 0;
            //
            model.FUnitID = fUnitID;
            model.FAuxBCommitQty = 0;
            model.FAuxCommitQty = 0;
            model.FAuxInvoiceQty = 0;
            //
            model.FAuxPrice = fAuxPrice;
            //
            model.FAuxQty = fAuxQty;
            model.FSourceEntryID = 0;
            //
            model.FQtyPass = fQtyPass;
            //
            model.FAuxQtyPass = fAuxQtyPass;
            model.FMapNumber = "";
            model.FMapName = "";
            //
            model.FBatchNo = fBatchNo;
            //
            model.FKFDate = fKFDate;
            //
            model.FKFPeriod = fKFPeriod;
            model.FDCSPID = fDCSPID;
            model.FAuxPropID = fAuxPropID;
            model.FDCStockID = 0;
            //
            //model.FFetchDate = null;
            model.FSecCoefficient = 0;
            model.FSecQty = 0;
            model.FSecCommitQty = 0;
            model.FSourceTranType = 0;
            model.FSourceInterId = 0;
            model.FSourceBillNo = "";
            model.FContractInterID = 0;
            model.FContractEntryID = 0;
            model.FContractBillNo = "";
            model.FOrderInterID = 0;
            model.FOrderEntryID = 0;
            model.FOrderBillNo = "";
            //
            model.FStockID = fStockID;
            //
            model.FPeriodDate = fPeriodDate;
            model.FNotPassQty = 0;
            model.FNPCommitQty = 0;
            model.FSampleBreakQty = 0;
            model.FConPassQty = 0;
            model.FConCommitQty = 0;
            model.FAuxNotPassQty = 0;
            model.FAuxNPCommitQty = 0;
            model.FAuxSampleBreakQty = 0;
            model.FAuxConPassQty = 0;
            model.FAuxConCommitQty = 0;
            model.FAuxRelateQty = 0;
            model.FRelateQty = 0;
            model.FBackQty = 0;
            model.FAuxBackQty = 0;
            model.FSecBackQty = 0;
            model.FSecConCommitQty = 0;
            model.FPlanMode = 14036;
            model.FMTONo = "";
            model.FOrderType = 0;
            model.FEntryAccessoryCount = 0;
            model.FDeliveryNoticeEntryID = 0;
            model.FDeliveryNoticeFID = 0;
            model.FDischarged = 1059;
            model.FCheckMethod = 352;
            model.FScrapQty = 0;
            model.FAuxScrapQty = 0;
            model.FSecScrapQty = 0;
            model.FSecConCommiqty = 0;
            model.FScrapInCommitQty = 0;
            model.FAuxScrapInCommitQty = 0;
            model.FSecScrapInCommitQty = 0;
            model.FSecQtyPass = 0;
            model.FSecConPassQty = 0;
            model.FSecNotPassQty = 0;
            model.FSecSampleBreakQty = 0;
            model.FSecRelateQty = 0;
            model.FSecQCheckQty = 0;
            model.FBackType = 0;
            model.FTime = 1;
            model.FSampleConclusion = 0;
            model.FSamBillNo = "";
            model.FSamInterID = 0;
            model.FSamEntryID = 0;
            //alcon行号
            model.FEntrySelfP0386 = fEntrySelfP0386;
            //现有文件里已经没有了
            //model.FEntrySelfP0387 = "";

            if (dalPOInStockEntry.Add(model) == true)
            {
                retVal = true;
            }

            return retVal;

        }
    }
    #endregion

    #region T_User
    public partial class T_User
    {
        public int Login(string UserName, string password)
        {
            int retVal = 0;
            object obj =SqlHelper.ExecuteScalar(" SELECT fsid FROM t_user WHERE fName ='" + UserName + "' ");
            if (obj != null && obj.ToString().Trim() == PassService.EncryptPassword(password, 12).Trim())
            {
                object fUserId = SqlHelper.ExecuteScalar(" SELECT fuserid FROM t_user WHERE fName ='" + UserName + "' ", null);
                if (fUserId != null)
                {
                    retVal = int.Parse(fUserId.ToString());
                }
                else
                {
                    retVal = 0;
                }
            }
            else
            {
                retVal = 0;
            }
            return retVal;
        }
    }

    #endregion

    #region t_AuxItem
    public partial class t_AuxItem 
    {
        public int getAuxPropIDByKey(string key)
        {
            int retVal = 0;
            
            if (key == "见包装")
            {
                retVal = 0;
            }
            object temp = SqlHelper.ExecuteScalar(" SELECT FItemID  FROM t_auxItem WHERE fName = '"+key+"' ");

            retVal = temp != null ? int.Parse(temp.ToString()) : 0;
            return retVal;
        }
    }
    #endregion
}
