namespace IPV4Validation
{
    public class Validator
    {

        public bool isValid(string ipv4)
        {
            bool result = true;
            bool isOctetValid = false;
            var octets = ipv4.Split('.');

            foreach (var octet in octets)
            {
                int o;
                isOctetValid = int.TryParse(octet, out o);

                if (!isOctetValid || octets.Length != 4 || o < 0 || o > 255  || octet.Substring(0,1) == "0")
                {
                    result = false;
                    break;
                }                  
            }

            return result;
        }
    }
}
