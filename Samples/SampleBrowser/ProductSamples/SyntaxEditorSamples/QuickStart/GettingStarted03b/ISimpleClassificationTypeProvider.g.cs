namespace ActiproSoftware.ProductSamples.SyntaxEditorSamples.QuickStart.GettingStarted03b {
    using ActiproSoftware.Text;
    
    
    /// <summary>
    /// Provides the base requirements of an object that provides <see cref="IClassificationType"/> objects for the <c>Simple</c> language.
    /// </summary>
    /// <remarks>
    /// This type was generated by the Actipro Language Designer tool v11.1.542.0 (http://www.actiprosoftware.com).
    /// Generated code is based on input created by Actipro Software LLC.
    /// Copyright (c) 2001-2021 Actipro Software LLC.  All rights reserved.
    /// </remarks>
    public interface ISimpleClassificationTypeProvider {
        
        /// <summary>
        /// Gets the <c>Comment</c> classification type.
        /// </summary>
        /// <value>The <c>Comment</c> classification type.</value>
        IClassificationType Comment {
            get;
        }
        
        /// <summary>
        /// Gets the <c>Delimiter</c> classification type.
        /// </summary>
        /// <value>The <c>Delimiter</c> classification type.</value>
        IClassificationType Delimiter {
            get;
        }
        
        /// <summary>
        /// Gets the <c>Identifier</c> classification type.
        /// </summary>
        /// <value>The <c>Identifier</c> classification type.</value>
        IClassificationType Identifier {
            get;
        }
        
        /// <summary>
        /// Gets the <c>Keyword</c> classification type.
        /// </summary>
        /// <value>The <c>Keyword</c> classification type.</value>
        IClassificationType Keyword {
            get;
        }
        
        /// <summary>
        /// Gets the <c>Number</c> classification type.
        /// </summary>
        /// <value>The <c>Number</c> classification type.</value>
        IClassificationType Number {
            get;
        }
        
        /// <summary>
        /// Gets the <c>Operator</c> classification type.
        /// </summary>
        /// <value>The <c>Operator</c> classification type.</value>
        IClassificationType Operator {
            get;
        }
    }
}
