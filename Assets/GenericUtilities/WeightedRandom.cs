using UnityEngine;

namespace Rondo.Generic.Utility {

    public class WeightedRandom<T> {
        private T[] m_Values;
        private int[] m_Weights;
        private int m_TotalWeight = 0;

        public WeightedRandom(T[] values, int[] weights) {
            if (values.Length != weights.Length) throw new System.Exception("Values and weights are not equal in a weighted random class!");
            m_Values = values;

            m_Weights = new int[weights.Length];
            for (int i = 0; i < weights.Length; i++) {
                int currentWeight = weights[i] * 100;
                m_TotalWeight += currentWeight;
                m_Weights[i] = m_TotalWeight;
            }
        }

        public T GetRandomValue() {
            int chosenWeight = Random.Range(0, m_TotalWeight + 1);
            int currentWeight = 0;
            for(int i = 0; i < m_Weights.Length; i++) {
                int nextWeight = m_Weights[i];
                //chosen between current and next
                if (chosenWeight >= currentWeight && chosenWeight < nextWeight) {
                    return m_Values[i];
                }
                currentWeight = nextWeight;
            }
            return m_Values[m_Values.Length - 1];
        }

    }

}