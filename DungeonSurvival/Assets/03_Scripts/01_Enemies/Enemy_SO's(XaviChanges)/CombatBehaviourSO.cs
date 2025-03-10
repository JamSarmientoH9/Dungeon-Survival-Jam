using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "NewCombatBehaviour", menuName = "Dungeon Survival/Enemy/Combat/Combat Behaviour")]
public class CombatBehaviourSO : ScriptableObject
{
    public AttacksDataSO specialAtkData;
    public AttacksDataSO skillAtkData;
}
