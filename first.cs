public class TimelinePlayableWizard : EditorWindow
{
    public class Variable : IComparable
    {
        public string name;
        public UsableType usableType;

        int m_TypeIndex;

        public string NameAsPrivate
        {
            get
            {
                string returnVal = "m_" + name[0].ToString().ToUpper();
                for (int i = 1; i < name.Length; i++)
                {
                    returnVal += name[i];
                }
                return returnVal;
            }
        }

  public int CompareTo (object obj)
        {
            if (obj == null)
                return 1;//yes

            UsableType other = (UsableType)obj;

            if (other == null)
                throw new ArgumentException("This object is not a Variable.");

            return name.ToLower().CompareTo(other.name.ToLower());
        }
  public static UsableType[] GetUsableTypesFromVariableArray (Variable[] variables)
        {
            UsableType[] usableTypes = new UsableType[variables.Length];
            for (int i = 0; i < usableTypes.Length; i++)
            {
                usableTypes[i] = variables[i].usableType;
            }
            return usableTypes;
        }
