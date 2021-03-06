﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// This source code was auto-generated by xsd, Version=4.6.1055.0.
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("PolicySet", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class PolicySetType {
    
    private string descriptionField;
    
    private DefaultsType policySetDefaultsField;
    
    private TargetType targetField;
    
    private object[] itemsField;
    
    private ItemsChoiceType1[] itemsElementNameField;
    
    private ObligationType[] obligationsField;
    
    private string policySetIdField;
    
    private string policyCombiningAlgIdField;
    
    /// <remarks/>
    public string Description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public DefaultsType PolicySetDefaults {
        get {
            return this.policySetDefaultsField;
        }
        set {
            this.policySetDefaultsField = value;
        }
    }
    
    /// <remarks/>
    public TargetType Target {
        get {
            return this.targetField;
        }
        set {
            this.targetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Policy", typeof(PolicyType))]
    [System.Xml.Serialization.XmlElementAttribute("PolicyIdReference", typeof(string), DataType="anyURI")]
    [System.Xml.Serialization.XmlElementAttribute("PolicySet", typeof(PolicySetType))]
    [System.Xml.Serialization.XmlElementAttribute("PolicySetIdReference", typeof(string), DataType="anyURI")]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType1[] ItemsElementName {
        get {
            return this.itemsElementNameField;
        }
        set {
            this.itemsElementNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Obligation", IsNullable=false)]
    public ObligationType[] Obligations {
        get {
            return this.obligationsField;
        }
        set {
            this.obligationsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string PolicySetId {
        get {
            return this.policySetIdField;
        }
        set {
            this.policySetIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string PolicyCombiningAlgId {
        get {
            return this.policyCombiningAlgIdField;
        }
        set {
            this.policyCombiningAlgIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("PolicySetDefaults", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class DefaultsType {
    
    private string itemField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("XPathVersion", DataType="anyURI")]
    public string Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("Action", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class ActionType {
    
    private ActionMatchType[] actionMatchField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ActionMatch")]
    public ActionMatchType[] ActionMatch {
        get {
            return this.actionMatchField;
        }
        set {
            this.actionMatchField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("ActionMatch", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class ActionMatchType {
    
    private AttributeValueType attributeValueField;
    
    private object itemField;
    
    private string matchIdField;
    
    /// <remarks/>
    public AttributeValueType AttributeValue {
        get {
            return this.attributeValueField;
        }
        set {
            this.attributeValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ActionAttributeDesignator", typeof(AttributeDesignatorType))]
    [System.Xml.Serialization.XmlElementAttribute("AttributeSelector", typeof(AttributeSelectorType))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string MatchId {
        get {
            return this.matchIdField;
        }
        set {
            this.matchIdField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AttributeAssignmentType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("AttributeValue", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class AttributeValueType {
    
    private System.Xml.XmlNode[] anyField;
    
    private string dataTypeField;
    
    private System.Xml.XmlAttribute[] anyAttrField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlTextAttribute()]
    [System.Xml.Serialization.XmlAnyElementAttribute()]
    public System.Xml.XmlNode[] Any {
        get {
            return this.anyField;
        }
        set {
            this.anyField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string DataType {
        get {
            return this.dataTypeField;
        }
        set {
            this.dataTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAnyAttributeAttribute()]
    public System.Xml.XmlAttribute[] AnyAttr {
        get {
            return this.anyAttrField;
        }
        set {
            this.anyAttrField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(SubjectAttributeDesignatorType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("ResourceAttributeDesignator", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class AttributeDesignatorType {
    
    private string attributeIdField;
    
    private string dataTypeField;
    
    private string issuerField;
    
    private bool mustBePresentField;
    
    public AttributeDesignatorType() {
        this.mustBePresentField = false;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string AttributeId {
        get {
            return this.attributeIdField;
        }
        set {
            this.attributeIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string DataType {
        get {
            return this.dataTypeField;
        }
        set {
            this.dataTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Issuer {
        get {
            return this.issuerField;
        }
        set {
            this.issuerField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool MustBePresent {
        get {
            return this.mustBePresentField;
        }
        set {
            this.mustBePresentField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("AttributeSelector", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class AttributeSelectorType {
    
    private string requestContextPathField;
    
    private string dataTypeField;
    
    private bool mustBePresentField;
    
    public AttributeSelectorType() {
        this.mustBePresentField = false;
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string RequestContextPath {
        get {
            return this.requestContextPathField;
        }
        set {
            this.requestContextPathField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string DataType {
        get {
            return this.dataTypeField;
        }
        set {
            this.dataTypeField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public bool MustBePresent {
        get {
            return this.mustBePresentField;
        }
        set {
            this.mustBePresentField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("Resource", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class ResourceType {
    
    private ResourceMatchType[] resourceMatchField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ResourceMatch")]
    public ResourceMatchType[] ResourceMatch {
        get {
            return this.resourceMatchField;
        }
        set {
            this.resourceMatchField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("ResourceMatch", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class ResourceMatchType {
    
    private AttributeValueType attributeValueField;
    
    private object itemField;
    
    private string matchIdField;
    
    /// <remarks/>
    public AttributeValueType AttributeValue {
        get {
            return this.attributeValueField;
        }
        set {
            this.attributeValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AttributeSelector", typeof(AttributeSelectorType))]
    [System.Xml.Serialization.XmlElementAttribute("ResourceAttributeDesignator", typeof(AttributeDesignatorType))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string MatchId {
        get {
            return this.matchIdField;
        }
        set {
            this.matchIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("Subject", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class SubjectType {
    
    private SubjectMatchType[] subjectMatchField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("SubjectMatch")]
    public SubjectMatchType[] SubjectMatch {
        get {
            return this.subjectMatchField;
        }
        set {
            this.subjectMatchField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("SubjectMatch", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class SubjectMatchType {
    
    private AttributeValueType attributeValueField;
    
    private object itemField;
    
    private string matchIdField;
    
    /// <remarks/>
    public AttributeValueType AttributeValue {
        get {
            return this.attributeValueField;
        }
        set {
            this.attributeValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AttributeSelector", typeof(AttributeSelectorType))]
    [System.Xml.Serialization.XmlElementAttribute("SubjectAttributeDesignator", typeof(SubjectAttributeDesignatorType))]
    public object Item {
        get {
            return this.itemField;
        }
        set {
            this.itemField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string MatchId {
        get {
            return this.matchIdField;
        }
        set {
            this.matchIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("SubjectAttributeDesignator", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class SubjectAttributeDesignatorType : AttributeDesignatorType {
    
    private string subjectCategoryField;
    
    public SubjectAttributeDesignatorType() {
        this.subjectCategoryField = "urn:oasis:names:tc:xacml:1.0:subject-category:access-subject";
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    [System.ComponentModel.DefaultValueAttribute("urn:oasis:names:tc:xacml:1.0:subject-category:access-subject")]
    public string SubjectCategory {
        get {
            return this.subjectCategoryField;
        }
        set {
            this.subjectCategoryField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("Target", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class TargetType {
    
    private SubjectsType subjectsField;
    
    private ResourcesType resourcesField;
    
    private ActionsType actionsField;
    
    /// <remarks/>
    public SubjectsType Subjects {
        get {
            return this.subjectsField;
        }
        set {
            this.subjectsField = value;
        }
    }
    
    /// <remarks/>
    public ResourcesType Resources {
        get {
            return this.resourcesField;
        }
        set {
            this.resourcesField = value;
        }
    }
    
    /// <remarks/>
    public ActionsType Actions {
        get {
            return this.actionsField;
        }
        set {
            this.actionsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("Subjects", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class SubjectsType {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnySubject", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("Subject", typeof(SubjectType))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("Resources", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class ResourcesType {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AnyResource", typeof(object))]
    [System.Xml.Serialization.XmlElementAttribute("Resource", typeof(ResourceType))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("Actions", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class ActionsType {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Action", typeof(ActionType))]
    [System.Xml.Serialization.XmlElementAttribute("AnyAction", typeof(object))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("Policy", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class PolicyType {
    
    private string descriptionField;
    
    private DefaultsType policyDefaultsField;
    
    private TargetType targetField;
    
    private RuleType[] ruleField;
    
    private ObligationType[] obligationsField;
    
    private string policyIdField;
    
    private string ruleCombiningAlgIdField;
    
    /// <remarks/>
    public string Description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public DefaultsType PolicyDefaults {
        get {
            return this.policyDefaultsField;
        }
        set {
            this.policyDefaultsField = value;
        }
    }
    
    /// <remarks/>
    public TargetType Target {
        get {
            return this.targetField;
        }
        set {
            this.targetField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Rule")]
    public RuleType[] Rule {
        get {
            return this.ruleField;
        }
        set {
            this.ruleField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Obligation", IsNullable=false)]
    public ObligationType[] Obligations {
        get {
            return this.obligationsField;
        }
        set {
            this.obligationsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string PolicyId {
        get {
            return this.policyIdField;
        }
        set {
            this.policyIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string RuleCombiningAlgId {
        get {
            return this.ruleCombiningAlgIdField;
        }
        set {
            this.ruleCombiningAlgIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("Rule", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class RuleType {
    
    private string descriptionField;
    
    private TargetType targetField;
    
    private ApplyType conditionField;
    
    private string ruleIdField;
    
    private EffectType effectField;
    
    /// <remarks/>
    public string Description {
        get {
            return this.descriptionField;
        }
        set {
            this.descriptionField = value;
        }
    }
    
    /// <remarks/>
    public TargetType Target {
        get {
            return this.targetField;
        }
        set {
            this.targetField = value;
        }
    }
    
    /// <remarks/>
    public ApplyType Condition {
        get {
            return this.conditionField;
        }
        set {
            this.conditionField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string RuleId {
        get {
            return this.ruleIdField;
        }
        set {
            this.ruleIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public EffectType Effect {
        get {
            return this.effectField;
        }
        set {
            this.effectField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("Apply", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class ApplyType {
    
    private object[] itemsField;
    
    private ItemsChoiceType[] itemsElementNameField;
    
    private string functionIdField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ActionAttributeDesignator", typeof(AttributeDesignatorType))]
    [System.Xml.Serialization.XmlElementAttribute("Apply", typeof(ApplyType))]
    [System.Xml.Serialization.XmlElementAttribute("AttributeSelector", typeof(AttributeSelectorType))]
    [System.Xml.Serialization.XmlElementAttribute("AttributeValue", typeof(AttributeValueType))]
    [System.Xml.Serialization.XmlElementAttribute("EnvironmentAttributeDesignator", typeof(AttributeDesignatorType))]
    [System.Xml.Serialization.XmlElementAttribute("Function", typeof(FunctionType))]
    [System.Xml.Serialization.XmlElementAttribute("ResourceAttributeDesignator", typeof(AttributeDesignatorType))]
    [System.Xml.Serialization.XmlElementAttribute("SubjectAttributeDesignator", typeof(SubjectAttributeDesignatorType))]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public ItemsChoiceType[] ItemsElementName {
        get {
            return this.itemsElementNameField;
        }
        set {
            this.itemsElementNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string FunctionId {
        get {
            return this.functionIdField;
        }
        set {
            this.functionIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("Function", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class FunctionType {
    
    private string functionIdField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string FunctionId {
        get {
            return this.functionIdField;
        }
        set {
            this.functionIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy", IncludeInSchema=false)]
public enum ItemsChoiceType {
    
    /// <remarks/>
    ActionAttributeDesignator,
    
    /// <remarks/>
    Apply,
    
    /// <remarks/>
    AttributeSelector,
    
    /// <remarks/>
    AttributeValue,
    
    /// <remarks/>
    EnvironmentAttributeDesignator,
    
    /// <remarks/>
    Function,
    
    /// <remarks/>
    ResourceAttributeDesignator,
    
    /// <remarks/>
    SubjectAttributeDesignator,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
public enum EffectType {
    
    /// <remarks/>
    Permit,
    
    /// <remarks/>
    Deny,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("Obligation", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class ObligationType {
    
    private AttributeAssignmentType[] attributeAssignmentField;
    
    private string obligationIdField;
    
    private EffectType fulfillOnField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("AttributeAssignment")]
    public AttributeAssignmentType[] AttributeAssignment {
        get {
            return this.attributeAssignmentField;
        }
        set {
            this.attributeAssignmentField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string ObligationId {
        get {
            return this.obligationIdField;
        }
        set {
            this.obligationIdField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public EffectType FulfillOn {
        get {
            return this.fulfillOnField;
        }
        set {
            this.fulfillOnField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("AttributeAssignment", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class AttributeAssignmentType : AttributeValueType {
    
    private string attributeIdField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public string AttributeId {
        get {
            return this.attributeIdField;
        }
        set {
            this.attributeIdField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy", IncludeInSchema=false)]
public enum ItemsChoiceType1 {
    
    /// <remarks/>
    Policy,
    
    /// <remarks/>
    PolicyIdReference,
    
    /// <remarks/>
    PolicySet,
    
    /// <remarks/>
    PolicySetIdReference,
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:oasis:names:tc:xacml:1.0:policy")]
[System.Xml.Serialization.XmlRootAttribute("Obligations", Namespace="urn:oasis:names:tc:xacml:1.0:policy", IsNullable=false)]
public partial class ObligationsType {
    
    private ObligationType[] obligationField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Obligation")]
    public ObligationType[] Obligation {
        get {
            return this.obligationField;
        }
        set {
            this.obligationField = value;
        }
    }
}
