﻿using ChessHelper.Domain.Entities.EntitiesPost;
using ChessHelper.Domain.Repositories.RepositoriesPost;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessHelper.Infrastructure.Repository.RepositoryPost
{
    public class HistoricalPartyRepository : IHistoricalPartyRepository
    {
        private PostContext DbContext;
        public HistoricalPartyRepository(PostContext context)
        {
            DbContext = context;
        }

        public bool AddHistoricalParty(HistoricalParty historicalParty)
        {
            throw new NotImplementedException();
        }

        public bool DeleteHistoricalParty(int id)
        {
            throw new NotImplementedException();
        }

        public IList<HistoricalParty> GetAllHistoricalParty()
        {
            return DbContext.HistoricalParties.ToList();
        }

        public HistoricalParty GetHistoricalParty(int id)
        {
            return DbContext.HistoricalParties.FirstOrDefault(x => x.Id == id);
        }

        public bool UpdateHistoricalParty(HistoricalParty historicalParty)
        {
            throw new NotImplementedException();
        }
    }
}
