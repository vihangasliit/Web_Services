﻿using Microsoft.IdentityModel.Tokens;

namespace Web_Services.Services
{
    public class EventMiddleware
    {
        public static async Task<bool> Authorizer(string headers, MongoDBService _mongoDBService)
        {
            var header = headers;
            if (headers.IsNullOrEmpty())
            {
                return true;
            }
            else
            {
                var decode = JWTDecoder.DecodeJwtToken(headers);
                var obj = decode.Payload.ToList();
                var chk = await _mongoDBService.GetProfileByEmail(obj[2].Value.ToString());
                //check whether user existance
                if (chk.IsNullOrEmpty()) return true;
                return false;
            }
        }
    }
}
