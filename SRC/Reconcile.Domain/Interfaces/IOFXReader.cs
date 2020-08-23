namespace Reconcile.Domain.Interfaces
{
    public interface IOFXReaderService
    {
        void ReadFileToDTO(string fileLocation);
    }
}