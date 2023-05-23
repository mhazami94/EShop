using AutoMapper;

namespace Identity.Application.AutoMapper
{
    public class RequestToCommandProfile : Profile
    {
        public RequestToCommandProfile()
        {
            //    CreateMap<RegisterCustomerRequest, RegisterCustomerCommand>()
            //.ConstructUsing(c => new RegisterCustomerCommand(c.Email, c.Name, c.Password, c.PasswordConfirm));
        }
    }
}
