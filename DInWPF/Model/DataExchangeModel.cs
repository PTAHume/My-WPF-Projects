namespace DInWPF.Model;


public record class UserLoggedIn(string UserName); //: IDataExchangeModel;

public interface IDataExchangeModel
{
    //public record class DataExchangeModel(string Message);
}//