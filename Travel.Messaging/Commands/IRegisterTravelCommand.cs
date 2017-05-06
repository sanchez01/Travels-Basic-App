using System;

namespace Travel.Messaging.Commands
{
    public interface IRegisterTravelCommand
    {
        int Id { get; }
        string FirstName { get;  }
        string LastName { get;  }
        string NatureTravel { get;  }
        string Country { get;  }
        string City { get;  }
        string State { get;  }
        DateTime From { get;  }
        DateTime To { get;  }
        string Address { get;  }
        string Hotel { get; }
        string ContactNumber { get;  }
    }
}
