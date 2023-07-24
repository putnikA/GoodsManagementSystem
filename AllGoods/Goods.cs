﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CashRegisterGoods.AllGoods
{
    public class Goods
    {
        private int _PLU;
        private string _name;
        private decimal? _quantity;
        private decimal _netPrice;
        private decimal _sellingPricePerUnit;
        private long _barcode;

        [Key]
        public int PLU
        {
            get { return _PLU; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("PLU must be a positive integer.");
                }
                _PLU = value;
            }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
                _name = value;
            }
        }

        public decimal? Quantity
        {
            get { return _quantity; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Quantity cannot be negative.");
                }
                _quantity = value;
            }
        }

        public decimal NetPrice
        {
            get { return _netPrice; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Net price cannot be negative.");
                }
                _netPrice = value;
            }
        }

        public decimal SellingPricePerUnit
        {
            get { return _sellingPricePerUnit; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Selling price per unit cannot be negative.");
                }
                _sellingPricePerUnit = value;
            }
        }

        public long Barcode
        {
            get { return _barcode; }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Barcode must be a positive integer.");
                }
                _barcode = value;
            }
        }
    }
}