<script lang="ts" setup>
import { ChevronRightIcon } from "@heroicons/vue/24/outline";
import IconButton from "./IconButton.vue";
import { HomeIcon } from "@heroicons/vue/24/outline";
let { elements = [] } = defineProps<{
  elements: { title: string; href: string }[];
}>();
</script>

<template>
  <div class="flex gap-2 text-sm">
    <div class="flex  group items-center">
      <a href="#"><IconButton :icon="HomeIcon" /></a>
      <span
        ><ChevronRightIcon class="w-5 text-zinc-400 group-[:last-child]:hidden"
      /></span>
    </div>
    <div v-for="page in elements" class="flex gap-1 group items-center">
      <a
        class="text-zinc-400 rounded-md group-[:not(:last-child)]:hover:text-zinc-900 duration-200 group-[:last-child]:text-cyan-500 px-3 py-2 group-[:not(:last-child)]:hover:bg-zinc-100"
        :href="page.href"
        >{{ page.title }}</a
      >
      <span
        ><ChevronRightIcon class="w-5 text-zinc-400 group-[:last-child]:hidden"
      /></span>
    </div>
  </div>
</template>
