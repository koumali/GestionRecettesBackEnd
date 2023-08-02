namespace AutomotiveApi.Utility;

public enum Permission
{
    /// <summary>
    /// MarquesController
    /// MarquesController
    /// AgencesController
    /// someMethods
    /// </summary>
    PlatformTopLevelPermission = 1,
    /// <summary>
    /// UsersController
    /// RolesController
    /// </summary>
    AgencyFirstLevelPermission = 2,
    /// <summary>
    /// clientController
    /// offresController
    /// ReservationController
    /// </summary>
    AgencySecondLevelPermission = 3,
    /// <summary>
    /// getMarques()
    /// getModels()
    /// </summary>
    AgencyThirdLevelPermission = 4,
    /// <summary>
    /// vehiculesController
    /// </summary>
    AgencyFourthLevelPermission = 5
}