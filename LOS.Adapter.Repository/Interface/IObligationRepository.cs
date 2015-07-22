
namespace LOS.Adapter.Data.Services.Interface
{
    /// <summary>
    /// IObligationRepository
    /// </summary>
    public interface IObligationRepository
    {
        /// <summary>
        /// Assigns the obligation number.
        /// </summary>
        /// <param name="request">The request.</param>
        void AssignObligationNumber(AssignObligationNumberCommand request);

        void CreateCurrentFeeSchedule(CreateCurrentFeeScheduleCommand request);
    }
}
