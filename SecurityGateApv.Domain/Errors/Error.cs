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
        public static readonly Error CommitError = new("Error.CommitError", "Error when saving to database see log for details");
        public static readonly Error DecryptError = new("Error.DecryptError", "Error when decrypt text");
        public Error(string code, string message)
        {
            Code = code;
            Message = message;
        }

        public string Code { get; }
        public string Message { get; }
        #region Valid input
        public static readonly Error NullInput = new("Error.Input", "Input param can't null");
        #endregion

        //Author error
        public static readonly Error CreateStaffError = new("Error.CreateStaff", "This role can not create staff");



        public static implicit operator string(Error error) { return error.Code; }
        //Domain Errors
        public static readonly Error NotFound = new("Error.Notfound", "Not found item");

        //User validation
        public static readonly Error NotFoundUser = new("Error.NotfoundUser", "Not found this user");
        public static readonly Error NotFoundDepartmentManagerById = new("Error.NotfoundDepartmentManager", "Not found departmentManager by id");
        public static readonly Error IncorrectPassword = new("Error.LoginError", "LoginError");
        public static readonly Error NotPermission = new("Error.User.NotPermission", "Permission not allow");


        #region VisitError
        //Visit error
        public static readonly Error NotFoundVisit = new("Error.Visit", "Not found this visit");
        public static readonly Error NotFoundVisitCurrentDate = new("Error.Visit", "There is no one visit in current day");
        public static readonly Error NotRoleNotPermission = new("Error.NotfoundVisit", "Not found this visit");
        #endregion

        #region VisitDetailError
        //Visit error
        public static readonly Error NotFoundVisitDetail = new("Error.VisitDetail", "Not found this VisitDetail");
        //public static readonly Error NotFoundVisitCurrentDate = new("Error.Visit", "There is no one visit in current day");
        //public static readonly Error NotRoleNotPermission = new("Error.NotfoundVisit", "Not found this visit");
        #endregion

        //QRCard error
        public static readonly Error NotFoundQRCardById = new("Error.Notfound", "Not found this QRCard");
        public static readonly Error NotFoundQRCard = new("Error.NotfoundQRCard", "Not found this QRCard");
        public static readonly Error CardAcctive = new("Error.CardStatus", "Card is acctive cannot accept");
        public static readonly Error CardInActive = new("Error.CardStatus", "Card is inactive cannot accept");

        #region
        //VisitSesson error 
        public static readonly Error NotFoundVisitSessonByQRId = new("Error.NotFound", "Not found this VisitorSession by QRId");
        public static readonly Error FailCreateSession = new("Error.CanNotCreate", "Create session checkin fail");
        public static readonly Error ValidSession = new("Error.VisitSesson", "Session check in can't check in duplicate");
        #endregion


        //Visitor eror
        public static readonly Error NotFoundVisitor = new("Error.NotfoundVisitor", "Not found this visitor");
        public static readonly Error CreateVisitor = new("Error.CreateVisitor", "Create error");




        //Schedule Error
        public static readonly Error ScheduleCreateError = new("Error.Schedule", "Can not create schedule");
        public static readonly Error ScheduleUpdateError = new("Error.Schedule", "Can not update schedule");
        public static readonly Error ScheduleSaveError = new("Error.Schedule", "Can not save schedule");
        public static readonly Error NotFoundSchedule = new("Error.Schedule", "Can not found Schedule");

        //ProcessVisit Error
        public static readonly Error ProcessVisitCreateDateError = new("Error.ProcessVisitCreateDateError", @"Date format is ""Mon,Tue,Sun""");
    
        
        
        
        //Department Error
        public static readonly Error NotFoundDepartment = new("Error.NotfoundDepartment", "Not found this department");
        public static readonly Error NotFoundDepartmentByDepartmentManagerId = new("Error.NotfoundDepartment", "Not found department by department manager id");
        public static readonly Error NotFoundDepartmentById = new("Error.NotfoundDepartment", "Not found department by id");
        public static readonly Error CreateDepartment = new("Error.CreateDepartment", "Create department error");

        //Detection Error
        public static readonly Error DetectionError = new("Error.DetectionError", "No valid object found");
    }
}
