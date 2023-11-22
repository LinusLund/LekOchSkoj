using EmptyBlazorApp1.Context;
using static EmptyBlazorApp1.Pages.Receipts;

namespace EmptyBlazorApp1.Services
{
    public class ReceiptService
    {
        private readonly AppDbContext _dbContext;

        public ReceiptService(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Receipt> GetAllReceipts()
        {
            return _dbContext.Receipts.ToList();
        }

        public Receipt GetReceiptById(int id)
        {
            return _dbContext.Receipts.Find(id);
        }

        public void AddReceipt(Receipt receipt)
        {
            _dbContext.Receipts.Add(receipt);
            _dbContext.SaveChanges();
        }

        public void UpdateReceipt(Receipt receipt)
        {
            _dbContext.Receipts.Update(receipt);
            _dbContext.SaveChanges();
        }

        public void DeleteReceipt(int id)
        {
            var receipt = _dbContext.Receipts.Find(id);
            if (receipt != null)
            {
                _dbContext.Receipts.Remove(receipt);
                _dbContext.SaveChanges();
            }
        }
    }
}
