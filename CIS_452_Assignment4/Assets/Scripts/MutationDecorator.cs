/*
     * (Levi Schoof)
     * (MutationDecorator)
     * (Assignment 4)
     * (The Abstract class that the decorators will derive from)
     */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class MutationDecorator : Monster
{
    [HideInInspector] public Monster monster;
    public override abstract string GetDescription();
}
