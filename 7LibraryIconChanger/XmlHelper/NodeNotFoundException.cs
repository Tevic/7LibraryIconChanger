/**
 * Author：张浩华
 * Time：2010-12-11
 * By HNZZ
 * http://www.cnblogs.com/zhhh
 */
using System;

namespace CSharpHelperLibrary
{
    public class NodeNotFoundException : Exception
    {
        public NodeNotFoundException() { }
        public NodeNotFoundException(string message) : base(message) { }
    }
}
