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
        public static readonly Error PasswordNotMatch = new("Error.PasswordNotMatch", "Password doesn't match");
        public static readonly Error CheckPasswordError = new("Error.CheckPasswordError", "Password double check doesn't match");
        public static readonly Error Unauthorized = new("Error.Unauthorized", "Unauthorized Access.");


        public static implicit operator string(Error error) { return error.Code; }
        //Domain Errors
        public static readonly Error NotFound = new("Error.Notfound", "Not found item");

        #region UserError
        //User validation
        public static readonly Error NotFoundUser = new("Error.NotfoundUser", "Not found this user");
        public static readonly Error CanNotUpdateUserName = new("Error.CanNotUpdateUserName", "Username can not change");
        public static readonly Error NotFoundDepartmentManagerById = new("Error.NotfoundDepartmentManager", "Not found departmentManager by id");
        public static readonly Error IncorrectPassword = new("Error.LoginError", "LoginError");
        public static readonly Error NotPermission = new("Error.User.NotPermission", "Permission not allow");
        //user canot update departement
        public static readonly Error CanNotUpdateDepartment = new("Error.CanNotUpdateDepartment", "Department can not change for account admin, manager, security");
        //user role does not match department
        public static readonly Error UserRoleNotMatchDepartment = new("Error.UserRoleNotMatchDepartment", "User role does not match department");
        #endregion


        #region VisitError
        //Visit error
        public static readonly Error NotFoundVisit = new("Error.Visit", "Not found this visit");
        public static readonly Error NotFoundVisitCurrentDate = new("Error.Visit", "There is no one visit in current day");
        public static readonly Error NotRoleNotPermission = new("Error.NotfoundVisit", "Not found this visit");
        public static readonly Error DuplicateVisitorDetail = new("Error.DuplicateVisitorDetail", "Duplicate visitor");
        public static readonly Error VisitorIsBusy = new("Error.VisitorIsBusy", "Visitor busy at ...");
        public static readonly Error NoValidDateForVisit = new("Error.NoValidDateForVisit", "No Date Valid for this schedule");
        public static readonly Error NoScheduleAssignForThisStaff = new("Error.NoScheduleAssignForThisStaff", "No Assigned Schedule for staff");
        #endregion

        #region VisitDetailError
        //Visit error
        public static readonly Error NotFoundVisitDetail = new("Error.VisitDetail", "Not found this VisitDetail");
        //public static readonly Error NotFoundVisitCurrentDate = new("Error.Visit", "There is no one visit in current day");
        //public static readonly Error NotRoleNotPermission = new("Error.NotfoundVisit", "Not found this visit");
        #endregion
        #region CardError
        //Card error
        public static readonly Error NotFoundQRCardById = new("Error.Notfound", "Not found this QRCard");
        public static readonly Error NotFoundQRCard = new("Error.NotfoundQRCard", "Not found this QRCard");
        public static readonly Error CardAcctive = new("Error.CardStatus", "Card is acctive cannot accept");
        public static readonly Error CardInActive = new("Error.CardStatus", "Card is inactive cannot accept");
        //DuplicateQRCard
        public static readonly Error DuplicateCard = new("Error.DuplicateCard", "Duplicate Card");
        #endregion

        # region VisitSesson
        //VisitSesson error 
        public static readonly Error NotFoundVisitSessonByQRId = new("Error.NotFound", "Not found this VisitorSession by QRId");
        public static readonly Error NotFoundVisitSesson = new("Error.NotFound", "Not found this VisitorSession");
        public static readonly Error FailCreateSession = new("Error.CanNotCreate", "Create session checkin fail");
        public static readonly Error ValidSession = new("Error.VisitSesson", "Session check in can't check in duplicate");
        #endregion


        //Visitor eror
        public static readonly Error NotFoundVisitor = new("Error.NotfoundVisitor", "Not found this visitor");
        public static readonly Error CreateVisitor = new("Error.CreateVisitor", "Create error");
        public static readonly Error DuplicateCardNumber = new("Error.DuplicateCardNumber", "Update error");



        #region Schedule

        //Schedule Error
        public static readonly Error ScheduleCreateError = new("Error.Schedule", "Can not create schedule");
        public static readonly Error ScheduleUpdateError = new("Error.Schedule", "Can not update schedule");
        public static readonly Error ScheduleSaveError = new("Error.Schedule", "Can not save schedule");
        public static readonly Error NotFoundSchedule = new("Error.Schedule", "Can not found Schedule");
        public static readonly Error ScheduleValid = new("Error.Schedule", "DaysOfProcess is not valid for the selected Visit Type.");
        public static readonly Error ScheduleCannotUpdate = new("Error.Schedule", "Can not update Schedule daily");
        #endregion


        #region ScheduleType
        //ScheduleType Error
        public static readonly Error ScheduleTypeCreateError = new("Error.ScheduleType", "Can not create schedule type");
        public static readonly Error ScheduleTypeUpdateError = new("Error.ScheduleType", "Can not update schedule type");
        public static readonly Error ScheduleTypeSaveError = new("Error.ScheduleType", "Can not save schedule type");
        //error when schedule type not found
        public static readonly Error NotFoundScheduleType = new("Error.ScheduleType", "Can not found Schedule Type");
        //error when schedule input is not valid
        public static readonly Error ScheduleTypeInputValid = new("Error.ScheduleType", "Wrong when input Schedule Type");
        #endregion
        #region CredentialCardType
        //CredentialCardType Error
        public static readonly Error CredentialCardTypeCreateError = new("Error.CredentialCardType", "Can not create Credential Card Type");
        public static readonly Error CredentialCardTypeUpdateError = new("Error.CredentialCardType", "Can not update Credential Card Type");
        //invalid input
        public static readonly Error CredentialCardTypeInputValid = new("Error.CredentialCardType", "Wrong when input Credential Card Type");
        #endregion

        //ProcessVisit Error
        public static readonly Error ProcessVisitCreateDateError = new("Error.ProcessVisitCreateDateError", @"Date format is ""Mon,Tue,Sun""");
    
        
        
        
        //Department Error
        public static readonly Error NotFoundDepartment = new("Error.NotfoundDepartment", "Not found this department");
        public static readonly Error NotFoundDepartmentByDepartmentManagerId = new("Error.NotfoundDepartment", "Not found department by department manager id");
        public static readonly Error NotFoundDepartmentById = new("Error.NotfoundDepartment", "Not found department by id");
        public static readonly Error CreateDepartment = new("Error.CreateDepartment", "Create department error");
        public static readonly Error UpdateDepartment = new("Error.UpdateDepartment", "Update department error");

        //Detection Error
        public static readonly Error DetectionError = new("Error.DetectionError", "No valid object found");

        //CardType Repo
        public static readonly Error CardFoundError = new("Error.CardFoundError", "Card not found");
    }
}
