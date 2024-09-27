using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecurityGateApv.Domain.Errors
{
    public class Error
    {
        public static readonly Error None = new(string.Empty, string.Empty);
        public static readonly Error NullValue = new("Error.NullValue", "The specified result value is null");

        public Error(string code, string message)
        {
            Code = code;
            Message = message;
        }

        public string Code { get; }
        public string Message { get; }

        public static implicit operator string(Error error) { return error.Code; }
        //Domain Errors
        public static readonly Error NotFound = new("Error.Notfound", "Not found item");

        //User validation
        public static readonly Error NotFoundUser = new("Error.NotfoundUser", "Not found this user");
        public static readonly Error IncorrectPassword = new("Error.LoginError", "LoginError");


        //Visit error
        public static readonly Error NotFoundVisit = new("Error.NotfoundVisit", "Not found this visit");
        public static readonly Error NotRoleNotPermission = new("Error.NotfoundVisit", "Not found this visit");

        //QRCard error
        public static readonly Error NotFoundQRCardById = new("Error.Notfound", "Not found this QRCard");
        public static readonly Error NotFoundQRCard = new("Error.NotfoundQRCard", "Not found this QRCard");
        public static readonly Error CardAcctive = new("Error.CardStatus", "Card is acctive cannot accept");


        //VisitSesson error 
        public static readonly Error NotFoundVisitSessonByQRId = new("Error.NotFound", "Not found this VisitorSession by QRId");
        public static readonly Error FailCreateSession = new("Error.CanNotCreate", "Create session checkin fail");



        //Visitor eror
        public static readonly Error NotFoundVisitor = new("Error.NotfoundVisitor", "Not found this visitor");




        //Process Error
        public static readonly Error ProcessCreateError = new("Error.Create", "Can not create process");
        public static readonly Error ProcessNotFoundError = new("Error.ProcessNotFoundError", "Can not found process");

        //ProcessVisit Error
        public static readonly Error ProcessVisitCreateDateError = new("Error.ProcessVisitCreateDateError", @"Date format is ""Mon,Tue,Sun""");
    }
}
