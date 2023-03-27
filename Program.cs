using System;

public class Class1
{
    public Class1()
    {
        List<parametros> _parametros = parametroDataAccess.GetParameters(); 
        
        var toPublish = new Dictionary<string, object> { }; 
        
        for (int i = 0; i < _parametros.Count; i++)
        {
            string _name = _parametros[i].Nome; switch (_name)
            {
                case "Limite Superior MgO":
                    toPublish.Add("L3_LIM_SUP_MGO", _parametros[i].Valor);
                    break;

                case "Limite Inferior MgO":
                    toPublish.Add("L3_LIM_INF_MGO", _parametros[i].Valor);
                    break;

                case "Meta MgO":
                    toPublish.Add("L3_META_MGO", _parametros[i].Valor);
                    break;

                case "Limite Superior Base":
                    toPublish.Add("L3_LIM_SUP_BASICIDADE", _parametros[i].Valor);
                    break;

                case "Limite Inferior Base":
                    toPublish.Add("L3_LIM_INF_BASICIDADE", _parametros[i].Valor);
                    break;

                case "Meta Basicidade":
                    toPublish.Add("L3_META_BASICIDADE", _parametros[i].Valor);
                    break;

                case "Limite Superior FeO":
                    toPublish.Add("L3_LIM_SUP_FeO", _parametros[i].Valor);
                    break;

                case "Limite Inferior FeO":
                    toPublish.Add("L3_LIM_INF_FeO", _parametros[i].Valor);
                    break;

                case "Meta FeO":
                    toPublish.Add("L3_META_FeO", _parametros[i].Valor);
                    break;

                case "Limite Superior SiO2":
                    toPublish.Add("L3_LIM_SUP_SiO2", _parametros[i].Valor);
                    break;

                case "Limite Inferior SiO2":
                    toPublish.Add("L3_LIM_INF_SiO2", _parametros[i].Valor);
                    break;

                case "Meta SiO2":
                    toPublish.Add("L3_META_SiO2", _parametros[i].Valor);
                    _p = _parametros.Where(p => p.Nome == "Limite Superior CaO").FirstOrDefault();
                    toPublish.Add("L3_LIM_SUP_Escoria", _parametros[i].Valor + _p.Valor);
                    _p = _parametros.Where(p => p.Nome == "Limite Inferior CaO").FirstOrDefault();
                    toPublish.Add("L3_LIM_INF_Escoria", _parametros[i].Valor + _p.Valor);
                    _p = _parametros.Where(p => p.Nome == "Meta CaO").FirstOrDefault();
                    toPublish.Add("L3_META_Escoria", _parametros[i].Valor + _p.Valor);
                    break;

                case "Limite Superior CaO":
                    toPublish.Add("L3_LIM_SUP_CaO", _parametros[i].Valor);
                    //_p = _parametros.Where(p => p.Nome == "Meta SiO2").FirstOrDefault(); 
                    //toPublish.Add("L3_LIM_SUP_Escoria", (_p != null ? _p.Valor : 0) + _parametros[i].Valor);
                    break;

                case "Limite Inferior CaO":
                    toPublish.Add("L3_LIM_INF_CaO", _parametros[i].Valor);
                    //_p = _parametros.Where(p => p.Nome == "Meta SiO2").FirstOrDefault(); 
                    //toPublish.Add("L3_LIM_INF_Escoria", (_p != null ? _p.Valor : 0) + _parametros[i].Valor);
                    break;

                case "Meta CaO":
                    toPublish.Add("L3_META_CaO", _parametros[i].Valor);
                    //_p = _parametros.Where(p => p.Nome == "Meta SiO2").FirstOrDefault(); 
                    //toPublish.Add("L3_META_Escoria", (_p != null ? _p.Valor : 0) + _parametros[i].Valor);
                    break;

                case "Limite Superior MnO":
                    toPublish.Add("L3_LIM_SUP_MnO", _parametros[i].Valor);
                    break;

                case "Limite Inferior MnO":
                    toPublish.Add("L3_LIM_INF_MnO", _parametros[i].Valor);
                    break;

                case "Meta MnO":
                    toPublish.Add("L3_META_MnO", _parametros[i].Valor);
                    break;

                default: break;
            }
        }
    }
}
	} 
}
