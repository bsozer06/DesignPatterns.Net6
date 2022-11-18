namespace DesignPatterns.Iterator
{
    public interface IIterator
    {
        /// <summary>
        ///  is there any item in next step
        /// </summary>
        /// <returns></returns>
        bool HasItem();

        /// <summary>
        /// Item in next step
        /// </summary>
        /// <returns></returns>
        Employee NextItem();

        /// <summary>
        /// Available item
        /// </summary>
        /// <returns></returns>
        Employee CurrentItem();
    }
}