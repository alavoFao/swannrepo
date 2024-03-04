   for (int d = 0; d < 4; d++)
        {
            propagator[d] = new int[T][];
            for (int t = 0; t < T; t++)
            {
                List<int> list = new();
                for (int t2 = 0; t2 < T; t2++) if (agrees(patterns[t], patterns[t2], dx[d], dy[d], N)) list.Add(t2);
                propagator[d][t] = new int[list.Count];
                for (int c = 0; c < list.Count; c++) propagator[d][t][c] = list[c];
            }
        }
    }//hello
  public override void Save(string filename)
    {
        int[] bitmap = new int[MX * MY];
        if (observed[0] >= 0)
        {
            for (int y = 0; y < MY; y++)
            {
                int dy = y < MY - N + 1 ? 0 : N - 1;
                for (int x = 0; x < MX; x++)
                {
                    int dx = x < MX - N + 1 ? 0 : N - 1;
                    bitmap[x + y * MX] = colors[patterns[observed[x - dx + (y - dy) * MX]][dx + dy * N]];
                }
            }
        }
