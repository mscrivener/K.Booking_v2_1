using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace K.Booking.Data
{
    public class GlobalEnums
    {
        public enum Gender
        {

            Undecided = 0,
            Male = 1,
            Female = 2,
        }
        public enum ResidentType
        {

            Undecided = 0,
            ShortTerm = 1,
            LongTerm = 2,
            Guest = 3,
            Appartement = 4,
            Staff = 5,
        }
        public enum PriceDesctiption
        {

            LongTermHigh = 1,
            LongTermLow = 2,
            ShortTerm = 3,
            GuestRoomDeposit = 4,
            FoodTicket = 5,
            LatePaymentFee = 6,
            CardPaymentFee = 7,
            Flat = 8,
            Guest = 9,
            Other = 0,
            CCFeeLongTerm = 10,
            CCFeeShortTerm = 11,
            CCFeeFlat = 12,
            LateFeeLongTerm = 13,
            LateFeeShortTerm = 14,
            LateFeeFlat = 15,
            LongTermNoFoodTicket = 16,
        }
        public enum RoomType
        {

            Room = 0,
            Appartement = 1,
        }
 
    }
}
